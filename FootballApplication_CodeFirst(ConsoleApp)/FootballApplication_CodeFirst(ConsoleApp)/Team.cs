using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication_CodeFirst_ConsoleApp_
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short YearOfFoundation { get; set; }
        public ICollection<Player> Players { get; set; } //There are more than 1 Player in a Team(Bir takımda birden çok oyuncu var.)
    }
}
