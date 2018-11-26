using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class ServiceVariant:ServiceBase
    {
        [XmlElement("CONSUMER")]
        public Consumer[] Consumers { get; set; }
    }
}