using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Work
    {
        [XmlAttribute("caption")]
        public string Caption { get; set; }

        [XmlAttribute("consumer")]
        public string Consumer { get; set; }

        [XmlAttribute("id")]
        public ulong Id { get; set; }

        [XmlAttribute("isNormalized")]
        public uint IsNormalized { get; set; }

        [XmlElement("QUALITY")]
        public Quality[] Qualities { get; set; }

        [XmlElement("VOLUME")]
        public Volume[] Volumes { get; set; }
    }
}
