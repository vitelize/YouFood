using System.Data.Entity;
using Models;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Plat> Plats { get; set; }
        public DbSet<Carte> Cartes { get; set; }

        public DbSet<Commande> Commandes { get; set; }
        public DbSet<PreparationPlat> PlatsEnCours { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Table> Tables { get; set; }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Serveur> Serveurs { get; set; }
        public DbSet<Cuisinier> Cuisiniers { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
