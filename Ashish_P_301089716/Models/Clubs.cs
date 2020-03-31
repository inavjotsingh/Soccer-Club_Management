using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public class Clubs
    {

        [Key]
        public int ClubId { get; set; }
        public string NameOfClub { get; set; }
        public string NameOfCoach { get; set; }
        public int StadiumCapacity { get; set; }
        public int NumberOfPlayers { get; set; }
        public string President { get; set; }
        public string LeagueParticipated { get; set; }

        public ICollection<Player> Players { get; set; }

      
    }

  
}