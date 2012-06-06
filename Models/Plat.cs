using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Plat
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public int TypePlatID { get; set; }
        public int SpecialiteID { get; set; }
        public bool Servi { get; set; }
    }
}
