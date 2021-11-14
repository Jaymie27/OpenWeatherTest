using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    static public class AppConfiguration
    {
        private static IConfiguration configuration;

        public static string GetValue(string key)
        {
            if(configuration == null)
            {
                initConfig();
            }
            return configuration.GetValue<string>(key);
        }

        public static void initConfig()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json").AddUserSecrets("2d5ccc99-d97f-44c7-bc6a-1835ad6b7646").Build();
        }
    }
}
