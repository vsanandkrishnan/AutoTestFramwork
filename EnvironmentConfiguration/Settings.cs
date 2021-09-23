using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentConfiguration
{
    public  class Settings
    {
        public static string projectPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("AutoTestFramework"));
        public static string configSettingPath = @"AutoTestFramework\EnvironmentConfiguration\Configuration\configsetting.json";
        public static string configPath = Path.Combine(projectPath, configSettingPath);
        public static  Configsetting config;
        public static void GetData()
        {
            config = new Configsetting();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configPath);

            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
        }
    }
}
