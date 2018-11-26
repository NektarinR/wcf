using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Agreement
{
    public class AgreementOrg
    {
        [XmlAttribute("agreementSumm")]
        public decimal AgreementSumm { get; set; }

        [XmlAttribute("budgetReqsSumm")]
        public decimal BudgetReqsSumm { get; set; }

        [XmlAttribute("caption")]
        public string Caption { get; set; }

        [XmlAttribute("id")]
        [Key]
        public ulong Id { get; set; }

        [XmlAttribute("subsidySumm")]
        public decimal SubsidySumm { get; set; }

        [XmlElement("SCHEDULE")]
        public List<Schedule> Schedules { get; set; }

        [XmlElement("BO")]
        public List<Bo> Boes { get; set; }
    }
}
