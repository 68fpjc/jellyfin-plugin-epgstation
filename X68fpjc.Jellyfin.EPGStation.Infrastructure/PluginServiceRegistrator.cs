using MediaBrowser.Common.Plugins;
using Microsoft.Extensions.DependencyInjection;
using X68fpjc.Jellyfin.EPGStation.Infrastructure;

namespace X68fpjc.Jellyfin.EPGStation
{
    public class PluginServiceRegistrator : IPluginServiceRegistrator
    {
        /// <inheritdoc />
        public void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IEpgstationClient, EpgstationDataSource>();
        }
    }
}
