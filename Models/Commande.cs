using System;

namespace Models
{
    public class Commande
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool EstRegle { get; set; }
        public double Prix { get; set; }
        public int MyProperty { get; set; }
        public int TableID { get; set; }

        //
        public Table table { get; set; }
    }
}
