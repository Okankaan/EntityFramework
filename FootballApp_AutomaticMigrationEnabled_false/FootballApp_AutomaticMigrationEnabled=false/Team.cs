using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp_AutomaticMigrationEnabled_false
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short YearOfFoundation { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
