using MediaBrowser.Controller;
using MediaBrowser.Controller.Plugins;
using Microsoft.Extensions.DependencyInjection;
using X68fpjc.Jellyfin.EPGStation.Infrastructure;

namespace X68fpjc.Jellyfin.EPGStation
{
    public class PluginServiceRegistrator : IPluginServiceRegistrator
    {
        public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost)
        {
            serviceCollection.AddScoped<IEpgstationClient, EpgstationDataSource>();
        }
    }
}
