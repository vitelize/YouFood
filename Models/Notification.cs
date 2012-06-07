using System;

namespace Models
{
    public enum TypeNotification
    {
        NouveauPlat,
        FinRepas,
    }

    public class Notification
    {
        public int ID { get; set; }
        public TypeNotification Type { get; set; }
        public DateTime Date { get; set; }
        public bool Fait { get; set; }

        //
        public Commande commande { get; set; }
    }
}
