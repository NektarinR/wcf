using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Agreement
{
    public class Agreement : Shared
    {
        [XmlAttribute("budgetId")]
        public ulong BudgetId { get; set; }

        [XmlAttribute("budgetSumm")]
        public decimal BudgetSumm { get; set; }

        [XmlAttribute("dateFrom")]
        public string DateFrom { get; set; }

        [XmlAttribute("dateTo")]
        public string DateTo { get; set; }

        public ulong AgreementOrgId { get; set; }

        [XmlElement("AGREEMENT_ORG")]
        [ForeignKey("AgreementOrgId")]
        public AgreementOrg AgreementOrg{get;set;}
    }
}
