using MediaBrowser.Model.Plugins;

namespace X68fpjc.Jellyfin.EPGStation.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string Url { get; set; }
        public int Limit { get; set; }
        public bool SyncRemove { get; set; }

        public PluginConfiguration()
        {
            Url = "http://localhost:8888";
            Limit = 1000;
            SyncRemove = false;
        }
    }
}
