using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class ServiceBase
    {

        [XmlAttribute("caption")]
        public string Caption { get; set; }

        [XmlAttribute("id")]
        public ulong Id { get; set; }

        [XmlElement("VOLUME")]
        public Volume[] Volumes { get; set; }

        [XmlElement("QUALITY")]
        public Quality[] Qualities { get; set; }

        [XmlAttribute("parament1")]
        public string Parametr1 { get; set; }

        [XmlAttribute("parament2")]
        public string Parametr2 { get; set; }

        [XmlAttribute("parament3")]
        public string Parametr3 { get; set; }

        [XmlAttribute("parament4")]
        public string Parametr4 { get; set; }

        [XmlAttribute("parament5")]
        public string Parametr5 { get; set; }

        [XmlAttribute("value1")]
        public string Value1 { get; set; }

        [XmlAttribute("value2")]
        public string Value2 { get; set; }

        [XmlAttribute("value3")]
        public string Value3 { get; set; }

        [XmlAttribute("value4")]
        public string Value4 { get; set; }

        [XmlAttribute("value5")]
        public string Value5 { get; set; }
    }
}