using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public interface IPlayerRepository
    {
        IQueryable<Player> Players { get; }
        void UpdatePlayer(int player, int club);
    }
}
