using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigManager
    {
        private static ConfigManager instance = new ConfigManager();
        private Dictionary<string, object> settings = new Dictionary<string, object>();

        public static ConfigManager Instance { get => instance; }

        private ConfigManager()
        {
        }

        public void Set(string key, object value)
        {
            settings.Add(key, value);
        }
        public object Get(string key)
        {
            return settings[key];
        }
    }
}
