using System;

namespace SUR_Integer_WAPRO.Modules.Configuration.Services
{
    class ConfigurationService
    {
        /// <summary>
        /// Get property from Properties.Setting of application
        /// </summary>
        /// <typeparam name="T"><T> - type of Properties.Setting</typeparam>
        /// <param name="name">string - property name</param>
        /// <returns>string - value of property</returns>
        public static T GetConfig<T>(string name)
        {
            return (T)Convert.ChangeType(Properties.Settings.Default[name], typeof(T));
        }

        /// <summary>
        /// Get property from Properties.Setting of application
        /// </summary>
        /// <typeparam name="T"><T> - type of Properties.Setting</typeparam>
        /// <param name="name">string - property name</param>
        /// <returns>string - value of property</returns>
        public static void SetConfig<T>(string name, T value)
        {
            Properties.Settings.Default[name] = value;
            Properties.Settings.Default.Save();
        }
    }
}
