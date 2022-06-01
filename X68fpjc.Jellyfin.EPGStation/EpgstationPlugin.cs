using System;
using System.Collections.Generic;
using System.Globalization;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using X68fpjc.Jellyfin.EPGStation.Configuration;

namespace X68fpjc.Jellyfin.EPGStation
{
    public class EpgstationPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public EpgstationPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public override string Name => "EPGStation";

        public override Guid Id => Guid.Parse("aa93bc86-2b92-4139-aa56-7cc83c282a32");

        public static EpgstationPlugin Instance { get; private set; }

        IEnumerable<PluginPageInfo> IHasWebPages.GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = Name,
                    EmbeddedResourcePath = string.Format(CultureInfo.InvariantCulture, "{0}.Configuration.configPage.html", GetType().Namespace)
                }
            };
        }
    }
}
