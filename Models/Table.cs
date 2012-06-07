
namespace Models
{
    public class Table
    {
        //Proprietés
        public int ID { get; set; }
        public int Capacite { get; set; }
        public int Numero { get; set; }
        
        //
        public Zone zone { get; set; }
        public Commande CommandeEnCours { get; set; }
    }
}
