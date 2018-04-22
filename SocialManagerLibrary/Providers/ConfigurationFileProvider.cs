using System;

namespace SocialManagerLibrary.Providers
{
    public class ConfigurationFileProvider : IConfigurationProvider
    {
        public T GetValue<T>(string key)
        {
            var value = System.Configuration.ConfigurationManager.AppSettings[key];            
            return (T)Convert.ChangeType(value, typeof(T)); 
        }
    }
}
