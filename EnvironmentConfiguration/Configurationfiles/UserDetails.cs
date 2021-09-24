using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EnvironmentConfiguration.Configurationfiles
{
    [Serializable]
    [XmlRoot(ElementName="UserDetails")]
    public class UserDetails
    {
        [XmlElement(ElementName ="User")]
        public List<User> userList = new List<User>();

    }

    [Serializable]
    [XmlRoot(ElementName ="User")]
    public class User
    {
        [XmlElement(ElementName ="UserId")]
        public int UserId { get; set; }

        [XmlElement(ElementName = "UserName")]
        public string UserName { get; set; }

        [XmlElement(ElementName = "Password")]
        public string Password { get; set; }
    }
}
