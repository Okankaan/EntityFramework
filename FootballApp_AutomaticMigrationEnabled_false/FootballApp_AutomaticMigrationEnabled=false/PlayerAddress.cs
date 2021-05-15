using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp_AutomaticMigrationEnabled_false
{
    public class PlayerAddress
    {
        [ForeignKey("Player")]
        public int PlayerAddressId { get; set; }
        public string City { get; set; }
        public int Street { get; set; }
        public int PostCode { get; set; }
        public Player Player { get; set; }
    }
}
