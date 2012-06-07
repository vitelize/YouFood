using System.Collections.Generic;

namespace Models
{
    public class Specialite
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }

        //
        public List<Plat> Plats { get; set; }
    }
}
