using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Tools.Configuration
{
    public class ConfigHandler : IConfigHandler
    {
        public T GetConfigValue<T>(string key) where T: class
        {
            var value = ConfigurationManager.AppSettings[key];

            return Convert.ChangeType(value, typeof(T)) as T;
        }
    }
}
