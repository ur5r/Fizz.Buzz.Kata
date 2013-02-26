using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Utility
{
    public class ConfigHelper
    {
        public static int GetIntegerFromConfig(string key)
        {
            int returnValue = 0;
            int.TryParse(readAppSettingsFromConfig(key), out returnValue);
            return returnValue;
        }
        public static string readAppSettingsFromConfig(string key)
        {
            return System.Configuration.ConfigurationSettings.AppSettings[key];
        }
    }
}
