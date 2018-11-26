using ConsoleApp1.Models.Agreement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Industry_list
{
    public class Industry:Shared
    {
        [XmlAttribute("periodFrom")]
        public string PeriodFrom { get; set; }

        [XmlAttribute("periodTo")]
        public string PeriodTo { get; set; }

        [XmlAttribute("status")]
        public string Status { get; set; }

        [XmlElement("WORK")]
        public Work[] Works { get; set; }

        [XmlElement("SERVICE")]
        public Service[] Services { get; set; }
    }
}
