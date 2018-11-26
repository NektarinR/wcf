using ConsoleApp1.Models.Agreement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Service:ServiceBase
    {

        [XmlAttribute("consumer")]
        public string Consumer { get; set; }

        [XmlAttribute("isCost")]
        public uint IsCost { get; set; }

        [XmlAttribute("industryEnumId")]
        public ulong IndustryEnumId { get; set; }

        [XmlAttribute("indCoef")]
        public decimal IndCoef { get; set; }

        [XmlAttribute("norma")]
        public decimal Norma { get; set; }

        [XmlAttribute("parentId")]
        public ulong ParentId { get; set; }

        [XmlAttribute("summ")]
        public decimal Summ { get; set; }

        [XmlAttribute("unit")]
        public decimal Unit { get; set; }

        [XmlAttribute("volume")]
        public decimal Volume { get; set; }

        [XmlAttribute("summCurrentYear")]
        public decimal SummCurrentYear { get; set; }

        [XmlAttribute("summNextYear")]
        public decimal SummNextYear { get; set; }

        [XmlElement("GROUP_ORG")]
        public GroupOrg[] GroupOrgs { get; set; }

        [XmlElement("SERVICE_VARIANT")]
        public ServiceVariant[] ServiceVariants { get; set; }
    }
}
