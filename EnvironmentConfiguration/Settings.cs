using EnvironmentConfiguration.Configurationfiles;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

    public class XMlConfiguration
    {
        public static string projectPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("AutoTestFramework"));
        public static string configSettingPath = @"AutoTestFramework\EnvironmentConfiguration\Configuration\UserFiles.xml";
        public static string configPath = Path.Combine(projectPath, configSettingPath);

        public static UserDetails GetUserDetails()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(UserDetails));
            TextReader reader = new StreamReader(configPath);
            object obj = deserializer.Deserialize(reader);
            UserDetails XmlData = (UserDetails)obj;
            reader.Close();
            return XmlData;
        }

    }

    
}
