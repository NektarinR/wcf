using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Agreement
{
    public class Schedule
    {
        public int Id { get; set; }

        [XmlAttribute("transferDate")]
        public string TransferDate { get; set; }

        [XmlAttribute("transferSumm")]
        public decimal TransferSumm { get; set; }
    }
}
