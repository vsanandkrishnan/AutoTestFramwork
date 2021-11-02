using EnvironmentConfiguration.Configurationfiles;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EnvironmentConfiguration
{
    public static class Settings
    {
        public static string projectPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("AutoTestFramework"));
        public static string configSettingPath = @"AutoTestFramework\EnvironmentConfiguration\Configuration\configsetting.json";
        public static string configPath = Path.Combine(projectPath, configSettingPath);
        public static  Configsetting config;
        public static StreamReader reader;

        public static void GetData()
        {
            //config = new Configsetting();

            //ConfigurationBuilder builder = new ConfigurationBuilder();
            //builder.AddJsonFile(configPath);

            //IConfigurationRoot configuration = builder.Build();
            //configuration.Bind(config);

            reader = new StreamReader(configPath);
            string jsonFile = reader.ReadToEnd();

            config = JsonConvert.DeserializeObject<Configsetting>(jsonFile);          
        }
    }

    public static class XMlConfiguration
    {
        public static string projectPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("AutoTestFramework"));
        public static string configSettingPath = @"AutoTestFramework\EnvironmentConfiguration\Configuration\";
        public static string configPath = Path.Combine(projectPath, configSettingPath);

        public static UserDetails GetUserDetails(string fileName)
        {
            var path=Path.Combine(configPath, fileName) + ".xml";
            XmlSerializer deserializer = new XmlSerializer(typeof(UserDetails));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            UserDetails XmlData = (UserDetails)obj;
            reader.Close();
            return XmlData;
        }

    }

    
}
