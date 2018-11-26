using System.Xml.Serialization;

namespace ConsoleApp1.Models.Subsidy
{
    public class Org
    {
        [XmlAttribute("caption")]
        public string Caption { get; set; }

        [XmlAttribute("dateFrom")]
        public string DateFrom { get; set; }

        [XmlAttribute("dateTo")]
        public string DateTo { get; set; }

        [XmlAttribute("id")]
        public ulong Id { get; set; }

        [XmlElement("SERVICE")]
        public Service[] Services { get; set; }

        [XmlElement("WORK")]
        public Work[] Works { get; set; }

        [XmlElement("PROPERTY")]
        public Property Property { get; set; }
    }
}