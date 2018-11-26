using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Subsidy
{
    [XmlRoot("return")]
    public class RootSubsidy
    {
        [XmlElement("SUBSIDY")]
        public Subsidy[] Subsidies { get; set; }
    }
}
