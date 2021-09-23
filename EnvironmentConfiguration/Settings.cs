using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentConfiguration
{
    public static class Settings
    {
        public static string configSettingPath = @"C:\Users\AnandKrishnan\source\repos\AutoTestFramework\EnvironmentConfiguration\Configuration\configsetting.json";
        public static  Configsetting config;
        public static void GetData()
        {
            config = new Configsetting();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingPath);

            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
        }
    }
}
