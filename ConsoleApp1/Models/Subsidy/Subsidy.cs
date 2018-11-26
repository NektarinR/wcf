using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Subsidy
{
    public class Subsidy:Shared
    {
        [XmlAttribute("budgetId")]
        public ulong BudgetId { get; set; }
        
        [XmlElement("ORG")]
        public Org Org { get; set; }
    }
}
