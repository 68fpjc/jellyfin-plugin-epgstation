using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using X68fpjc.Jellyfin.EPGStation.OpenAPI.Api;

namespace X68fpjc.Jellyfin.EPGStation.Infrastructure
{
    public class EpgstationDataSource : IEpgstationClient
    {
        async Task<Recorded> IEpgstationClient.FindRecordedByIdAsync(int recordedId, string url, int limit, CancellationToken cancellationToken)
        {
            var recordedItem = await CreateApi(url).RecordedRecordedIdGetAsync(
                recordedId: recordedId,
                isHalfWidth: true,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return recordedItem == null ? null
                : new Recorded(
                    recordedItem.Id,
                    recordedItem.Name,
                    recordedItem.Description,
                    recordedItem.Extended,
                    recordedItem.StartAt,
                    recordedItem.EndAt,
                    recordedItem.Thumbnails);
        }

        async Task<Recorded> IEpgstationClient.FindRecordedByFilenameAsync(string pathname, string url, int limit, CancellationToken cancellationToken)
        {
            string filename = Path.GetFileName(pathname);
            var records = await CreateApi(url).RecordedGetAsync(
                isHalfWidth: true,
                limit: limit,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return records._Records
                    .Where(a => a.VideoFiles
                        .Any(b => b.Filename.Equals(filename)))
                    .Select(a => new Recorded(
                        a.Id,
                        a.Name,
                        a.Description,
                        a.Extended,
                        a.StartAt,
                        a.EndAt,
                        a.Thumbnails))
                    .FirstOrDefault();
        }

        async Task<IEnumerable<Recorded>> IEpgstationClient.FindRecordedByKeywordAsync(string keyword, string url, int limit, CancellationToken cancellationToken)
        {
            var records = await CreateApi(url).RecordedGetAsync(
                isHalfWidth: true,
                limit: limit,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return records._Records
                .Where(a =>
                    a.Name.Contains(keyword)
                    || (a.Description != null && a.Description.Contains(keyword))
                    || (a.Extended != null && a.Extended.Contains(keyword)))
                .Select(a => new Recorded(
                    a.Id,
                    a.Name,
                    a.Description,
                    a.Extended,
                    a.StartAt,
                    a.EndAt,
                    a.Thumbnails));
        }

        async Task IEpgstationClient.DeleteVideoFileAsync(int recordedId, string pathname, string url, int limit, CancellationToken cancellationToken)
        {
            string filename = Path.GetFileName(pathname);
            var recordedItem = await CreateApi(url).RecordedRecordedIdGetAsync(
                recordedId: recordedId,
                isHalfWidth: true,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            if (recordedItem != null)
            {
                var videoFile = recordedItem.VideoFiles
                    .Where(a => a.Filename.Equals(filename))
                    .FirstOrDefault();
                if (videoFile != null)
                {
                    _ = CreateVideosApi(url).VideosVideoFileIdDeleteAsync(videoFile.Id, cancellationToken)
                        .ConfigureAwait(false);
                }
            }
        }

        private static RecordedApi CreateApi(string url)
        {
            return new (new OpenAPI.Client.Configuration
            {
                BasePath = url + "/api"
            });
        }

        private static VideosApi CreateVideosApi(string url)
        {
            return new (new OpenAPI.Client.Configuration
            {
                BasePath = url + "/api"
            });
        }
    }
}
