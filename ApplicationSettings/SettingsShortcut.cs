using ApplicationSettings.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSettings
{
    public static class SettingsShortcut
    {
        public static Settings Settings
        {
            get
            {
                return Settings.Default;
            }
        }
    }
}
