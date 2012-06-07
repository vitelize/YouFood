
namespace Models
{
    public enum TypePlat
    {
        entrée,
        PlatPrincipal,
        Fromage,
        Dessert   
    }

    public class Plat
    {
        public int ID { get; set; }
        public TypePlat Type { get; set; }
        public Specialite Region { get; set; }

        public string Nom { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public int TypePlatID { get; set; }
        public int SpecialiteID { get; set; }
        public bool Servi { get; set; }
    }
}
