using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication_CodeFirst_ConsoleApp_
{
    public class FootballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAddress> Addresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public FootballContext() : base("FootballDbConStr")
        {

        }
    }
}
