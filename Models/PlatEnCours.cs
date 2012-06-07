using System;

namespace Models
{
    public class PreparationPlat
    {
        public int Id { get; set; }
        public Plat PlatAFaire { get; set; }
        public int CommandeId { get; set; }
        public Cuisinier Preparateur { get; set; }
        public DateTime DateSoumission { get; set; }
    }
}
