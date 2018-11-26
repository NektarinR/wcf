using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Models.Agreement
{
    public class Bo
    {
        public int Id { get; set; }

        [XmlAttribute("Bo_number")]
        public string Bo_number { get; set; }

        [XmlAttribute("amount")]
        public decimal Amount { get; set; }

        [XmlAttribute("grbs")]
        public ushort Grbs { get; set; }

        [XmlAttribute("kcsr")]
        public string Kcsr { get; set; }

        [XmlAttribute("kesr")]
        public uint Kesr { get; set; }

        [XmlAttribute("kfsr")]
        public ushort Kfsr { get; set; }

        [XmlAttribute("kvr")]
        public ushort Kvr { get; set; }

        [XmlAttribute("period")]
        public ushort Perido { get; set; }
    }
}
