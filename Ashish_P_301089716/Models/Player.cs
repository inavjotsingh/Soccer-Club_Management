using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }

        public decimal age { get; set; }

        public string Nationality { get; set; }

        public int MatchPlayer { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Clubs Club { get; set; }
    }
}
