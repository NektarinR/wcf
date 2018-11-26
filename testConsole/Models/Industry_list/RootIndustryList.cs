using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Industry_list
{
    [XmlRoot("return")]
    public class RootIndustryList
    {
        [XmlElement("INDUSTRY_LIST")]
        public Industry[] Industries { get; set; }
    }
}
