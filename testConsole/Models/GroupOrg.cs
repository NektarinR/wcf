using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class GroupOrg
    {
        [XmlAttribute("caption")]
        public string Caption { get; set; }
    }
}