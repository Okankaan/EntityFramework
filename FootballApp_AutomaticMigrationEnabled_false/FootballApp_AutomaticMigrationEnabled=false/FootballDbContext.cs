using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp_AutomaticMigrationEnabled_false
{
    public class FootballDbContext:DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAddress> Addresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public FootballDbContext():base("FootballDbConStr")
        {

        }
    }
}
