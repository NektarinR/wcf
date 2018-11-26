using System.Xml.Serialization;

namespace ConsoleApp1.Models.Subsidy
{
    public class Property
    {
        [XmlAttribute("calcArea")]
        public decimal CalcArea { get; set; }

        [XmlAttribute("closeAreaSumm")]
        public decimal CloseAreaSumm { get; set; }

        [XmlAttribute("indCoef")]
        public decimal IndCoef { get; set; }

        [XmlAttribute("leasedArea")]
        public decimal LeasedArea { get; set; }

        [XmlAttribute("norma")]
        public decimal Norma { get; set; }

        [XmlAttribute("ownArea")]
        public decimal OwnArea { get; set; }

        [XmlAttribute("summ")]
        public decimal Summ { get; set; }

        [XmlAttribute("summCurrentYear")]
        public decimal SummCurrentYear { get; set; }

        [XmlAttribute("summNextYear")]
        public decimal SummNextYear { get; set; }
    }
}