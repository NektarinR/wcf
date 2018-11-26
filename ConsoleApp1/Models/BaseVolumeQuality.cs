using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class BaseVolumeQuality
    {
        [XmlAttribute("caption")]
        public string Caption { get; set; }

        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
