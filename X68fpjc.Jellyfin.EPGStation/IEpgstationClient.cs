using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace X68fpjc.Jellyfin.EPGStation
{
    public interface IEpgstationClient
    {
        Task<Recorded> FindRecordedByIdAsync(int recordedId, string url, int limit, CancellationToken cancellationToken);

        Task<Recorded> FindRecordedByFilenameAsync(string pathname, string url, int limit, CancellationToken cancellationToken);

        Task<IEnumerable<Recorded>> FindRecordedByKeywordAsync(string keyword, string url, int limit, CancellationToken cancellationToken);

        Task DeleteVideoFileAsync(int recordedId, string pathname, string url, int limit, CancellationToken cancellationToken);
    }

    public class Recorded
    {
        public Recorded(int id, string name, string description, string extended, long startAt, long endAt, List<int> thumbnails)
        {
            Id = id;
            Name = name;
            Description = description;
            Extended = extended;
            StartAt = startAt;
            EndAt = endAt;
            Thumbnails = thumbnails;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Extended { get; private set; }

        public long StartAt { get; private set; }

        public long EndAt { get; private set; }

        public List<int> Thumbnails { get; private set; }
    }
}
