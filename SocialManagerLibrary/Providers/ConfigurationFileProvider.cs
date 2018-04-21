using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
