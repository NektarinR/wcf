using ConsoleApp1.Models;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.List_Service_Work
{
    public class ServiceWork:Shared
    {
        [XmlAttribute("periodFrom")]
        public string PeriodFrom { get; set; }

        [XmlAttribute("periodTo")]
        public string PeriodTo { get; set; }

        [XmlElement("SERVICE")]
        public Service[] Services { get; set; }

        [XmlElement("WORK")]
        public Work[] Works { get; set; }
    }
}