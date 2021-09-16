using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tests.XMLConfiguration
{
    [Serializable]
    [XmlRoot(ElementName ="Book")]
    public class Book
    {
        [XmlElement(ElementName ="Bookname")]
        public string Bookname { get; set; }

        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "Author")]
        public string Author { get; set; }

        [XmlElement(ElementName = "Price")]
        public int Price { get; set; }

    }
}
