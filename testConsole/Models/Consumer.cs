using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Consumer
    {
        [XmlAttribute("caption")]
        public string Caption { get; set; }
    }
}