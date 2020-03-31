using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;
        public EFPlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Player> Players => context.Players.Include(a => a.Club);

        public void UpdatePlayer(int player, int club)
        {
            Console.WriteLine("-------------------------",player);
            Player p1 = context.Players.FirstOrDefault(a => a.PlayerId == player);
            Clubs c1 = context.Clubs.FirstOrDefault(a => a.ClubId == club);
            p1.Club = c1;
            context.SaveChanges();
        }
    }
}
