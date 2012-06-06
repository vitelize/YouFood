using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Models;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Plat> Plats { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
