using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Providers;

namespace X68fpjc.Jellyfin.EPGStation.Providers
{
    public class EPGStationProvider : IRemoteMetadataProvider<Movie, MovieInfo>
    {
        /// <inheritdoc />
        public string Name => EpgstationPlugin.Instance.Name;

        private readonly IEpgstationClient _epgstationClient;

        public EPGStationProvider(IEpgstationClient epgstationClient, ILibraryManager libraryManager)
        {
            _epgstationClient = epgstationClient;
            libraryManager.ItemRemoved += OnItemRemoved;
        }

        /// <inheritdoc />
        Task<HttpResponseMessage> IRemoteSearchProvider.GetImageResponse(string url, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        async Task<MetadataResult<Movie>> IRemoteMetadataProvider<Movie, MovieInfo>.GetMetadata(MovieInfo info, CancellationToken cancellationToken)
        {
            var result = new MetadataResult<Movie>
            {
                HasMetadata = false
            };
            if (info.ProviderIds.TryGetValue(Name, out var providerId))
            {
                if (int.TryParse(providerId, out var recordedId))
                {
                    var searchResult = await _epgstationClient.FindRecordedByIdAsync(
                        recordedId,
                        EpgstationPlugin.Instance.Configuration.Url,
                        EpgstationPlugin.Instance.Configuration.Limit,
                        cancellationToken);
                    if (searchResult != null)
                    {
                        result.HasMetadata = true;
                        result.ResultLanguage = info.MetadataLanguage;
                        result.Item = ToMovie(searchResult);
                    }
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(info.Path))
                {
                    var searchResult = await _epgstationClient.FindRecordedByFilenameAsync(
                        info.Path,
                        EpgstationPlugin.Instance.Configuration.Url,
                        EpgstationPlugin.Instance.Configuration.Limit,
                        cancellationToken)
                        .ConfigureAwait(false);
                    if (searchResult != null)
                    {
                        result.HasMetadata = true;
                        result.ResultLanguage = info.MetadataLanguage;
                        result.Item = ToMovie(searchResult);
                    }
                }
            }
            return result;
        }

        /// <inheritdoc />
        async Task<IEnumerable<RemoteSearchResult>> IRemoteSearchProvider<MovieInfo>.GetSearchResults(MovieInfo searchInfo, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(searchInfo.Name))
            {
                return Enumerable.Empty<RemoteSearchResult>();
            }
            else
            {
                var searchResult = await _epgstationClient.FindRecordedByKeywordAsync(
                    searchInfo.Name,
                    EpgstationPlugin.Instance.Configuration.Url,
                    EpgstationPlugin.Instance.Configuration.Limit,
                    cancellationToken)
                    .ConfigureAwait(false);
                return searchResult.Select(a =>
                {
                    var ret = new RemoteSearchResult
                    {
                        Name = a.Name,
                        Overview = a.Description + "\n\n" + a.Extended,
                        PremiereDate = DateTimeOffset.FromUnixTimeMilliseconds(a.StartAt).LocalDateTime,
                        ImageUrl = a.Thumbnails == null || a.Thumbnails.Count == 0
                            ? null
                            : EpgstationPlugin.Instance.Configuration.Url + "/api/thumbnails/" + a.Thumbnails[0].ToString()
                    };
                    ret.ProviderIds.Add(Name, a.Id.ToString());
                    return ret;
                });
            }
        }

        private Movie ToMovie(Recorded sour)
        {
            var ret = new Movie
            {
                Name = sour.Name,
                Overview = sour.Description + "\n\n" + sour.Extended,
                PremiereDate = DateTimeOffset.FromUnixTimeMilliseconds(sour.StartAt).LocalDateTime,
                EndDate = DateTimeOffset.FromUnixTimeMilliseconds(sour.EndAt).LocalDateTime
            };
            ret.ProviderIds.Add(Name, sour.Id.ToString());
            return ret;
        }

        private void OnItemRemoved(object sender, ItemChangeEventArgs e)
        {
            if (EpgstationPlugin.Instance.Configuration.SyncRemove
                && e.Item is Movie item
                && item.ProviderIds.TryGetValue(Name, out var providerId)
                && int.TryParse(providerId, out var recordedId)
                && item.Path != null)
            {
                using CancellationTokenSource cts = new CancellationTokenSource();
                _epgstationClient.DeleteVideoFileAsync(
                    recordedId,
                    item.Path,
                    EpgstationPlugin.Instance.Configuration.Url,
                    EpgstationPlugin.Instance.Configuration.Limit,
                    cts.Token);
            }
        }
    }
}
