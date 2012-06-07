using System;

namespace Models
{
    public class Carte
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        private int SpecialiteID { get; set; }

        public Specialite specialite { get; set; }
    }
}
