using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

namespace X68fpjc.Jellyfin.EPGStation.Providers
{
    public class ProviderId : IExternalId
    {
        /// <inheritdoc />
        string IExternalId.ProviderName => "EPGStation";

        /// <inheritdoc />
        string IExternalId.Key => ((IExternalId)this).ProviderName;

        /// <inheritdoc />
        ExternalIdMediaType? IExternalId.Type => ExternalIdMediaType.Movie;

        /// <inheritdoc />
        bool IExternalId.Supports(IHasProviderIds item) => item is Video;
    }
}
