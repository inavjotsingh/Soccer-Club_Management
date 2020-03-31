using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;
        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Clubs> Clubs => context.Clubs.Include(a=>a.Players);

        public Clubs AddClub(Clubs clubs)
        {
            context.Add(clubs);
            context.SaveChanges();
            return clubs;
        }

        public void UpdateClub(Clubs club)
        {
            
                Clubs cl = context.Clubs.FirstOrDefault(a => a.ClubId == club.ClubId);
                cl.NameOfClub = club.NameOfClub;
                cl.NameOfCoach = club.NameOfCoach;
                cl.NumberOfPlayers = club.NumberOfPlayers;
                cl.Players = club.Players;
                cl.President = club.President;
                cl.StadiumCapacity = club.StadiumCapacity;
                cl.Players = club.Players;
            
            context.SaveChanges();
        }

        public Clubs DeleteClub(int club)
        {
            Clubs dclub = context.Clubs.FirstOrDefault(a => a.ClubId == club);
            if(dclub != null)
            {
                context.Clubs.Remove(dclub);
                IEnumerable<Player> player = context.Players.Where(a => a.Club.ClubId == club);
                foreach(Player p in player)
                {
                    p.Club = null;
                }
                context.SaveChanges();
            }
            return dclub;
            
        }
    }
}
