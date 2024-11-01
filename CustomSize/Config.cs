using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace CustomSize    
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug is Enabled?")]
        public bool Debug { get; set; } = false;

        [Description("Does the plugin ignore SCP? ")]
        public bool IgnoreSCP { get; set; } = false;

        [Description("List of Random Custom Sizes, You can add your own directly from here, just type in the list")]
        public List<float> Size { get; private set; } = new()
        {
            1f,
            1.2f,
        };
    }
}