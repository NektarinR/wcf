using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Shared
    {
        [Key]
        public int Key { get; set; }

        [XmlAttribute("id")]
        public ulong Id { get; set; }

        [XmlAttribute("KADM")]
        public int Kadm { get; set; }

        [XmlAttribute("caption")]
        public string Caption { get; set; }
    }
}
