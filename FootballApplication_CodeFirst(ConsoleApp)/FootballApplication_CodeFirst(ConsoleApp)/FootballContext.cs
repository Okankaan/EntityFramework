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
        public FootballContext() : base("FootballDbConStr")
        {

        }
    }
}
