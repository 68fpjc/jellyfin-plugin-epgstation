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
        async Task<Recorded> IEpgstationClient.FindRecordedByIdAsync(int id, string url, int limit, CancellationToken cancellationToken)
        {
            var recordedApi = CreateApi(url);
            var ret = await recordedApi.RecordedRecordedIdGetAsync(
                recordedId: id,
                isHalfWidth: true,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return ret == null ? null
                : new Recorded(
                    ret.Id,
                    ret.Name,
                    ret.Description,
                    ret.Extended,
                    ret.StartAt,
                    ret.EndAt,
                    ret.Thumbnails);
        }

        async Task<Recorded> IEpgstationClient.FindRecordedByFilenameAsync(string pathname, string url, int limit, CancellationToken cancellationToken)
        {
            string filename = Path.GetFileName(pathname);
            var recordedApi = CreateApi(url);
            var records = await recordedApi.RecordedGetAsync(
                isHalfWidth: true,
                limit: limit,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return records._Records
                    .Where(a => a.VideoFiles
                        .Any(b => b.Filename.Equals(filename))
                    )
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
            var recordedApi = CreateApi(url);
            var records = await recordedApi.RecordedGetAsync(
                isHalfWidth: true,
                limit: limit,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);
            return records._Records
                .Where(a =>
                    a.Name.Contains(keyword)
                    || a.Description != null && a.Description.Contains(keyword)
                    || a.Extended != null && a.Extended.Contains(keyword))
                .Select(a => new Recorded(
                    a.Id,
                    a.Name,
                    a.Description,
                    a.Extended,
                    a.StartAt,
                    a.EndAt,
                    a.Thumbnails));
        }

        private static RecordedApi CreateApi(string url)
        {
            return new(new OpenAPI.Client.Configuration
            {
                BasePath = url + "/api"
            });
        }
    }
}
