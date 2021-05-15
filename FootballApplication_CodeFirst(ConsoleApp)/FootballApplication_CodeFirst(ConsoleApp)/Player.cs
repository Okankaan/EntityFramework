using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication_CodeFirst_ConsoleApp_
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Team Team { get; set; } //A Player has only one team(Bir oyuncunun sadece bir takımı vardır.)
        public PlayerAddress Address { get; set; } //A Player has only one PlayerAddress(Bir Oyuncunun sadece bir Adresi vardır.)
    }
}
