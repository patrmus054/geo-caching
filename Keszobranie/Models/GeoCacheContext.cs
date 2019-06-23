using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Models
{
    class GeoCacheContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Kesz> Caches { get; set; }
        public DbSet<Reputation> Reputations { get; set; }
        public DbSet<Found> Founds { get; set; }
    }
}
