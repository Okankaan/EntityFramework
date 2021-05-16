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
        public string NameOfTeam { get; set; }
        public short YearOfFoundation { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Sponsor> Sponsors { get; set; }
        public Country Country { get; set; }
    }
}
