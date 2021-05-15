using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication_CodeFirst_ConsoleApp_
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }//There are more than 1 Team in a Sponsor(Bir Sponsorun birden çok Takımı var.)
    }
}
