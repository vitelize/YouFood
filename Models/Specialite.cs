using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Specialite
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public System.Net.Mime.MediaTypeNames.Image Image { get; set; }

        //
        public List<Plat> Plats { get; set; }
    }
}
