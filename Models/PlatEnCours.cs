using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class PlatEnCours
    {
        public int Id { get; set; }
        public Plat PlatAFaire { get; set; }
        public int CommandeId { get; set; }
        public Cuisinier Preparateur { get; set; }
    }
}
