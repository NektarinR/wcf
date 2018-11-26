using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.List_Service_Work
{
    [XmlRoot("return")]
    public class RootListServiceWork
    {
        [XmlElement("LIST_SERVICE_WORK")]
        public ServiceWork[] ServiceWorks { get; set; }
    }
}
