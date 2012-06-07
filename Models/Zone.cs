using System.Collections.Generic;

namespace Models
{
    public class Zone
    {
        //proprités
        public int ID { get; set; }
        public string Description { get; set; }
        public int RestaurantID { get; set; }

        //
        public Serveur ServeurActif { get; set; }
        public List<Table> Tables { get; set; }
    }
}
