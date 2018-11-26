using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Agreement
{
    [XmlRoot("return")]
    public class RootAgreement
    {
        [XmlElement("AGREEMENT")]
        public Agreement[] Agreements { get; set; }
    }
}
