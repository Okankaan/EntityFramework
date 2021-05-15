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
        public FootballDbContext():base("FootballDbConStr")
        {

        }
    }
}
