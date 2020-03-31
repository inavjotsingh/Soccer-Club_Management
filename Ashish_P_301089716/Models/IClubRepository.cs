using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public interface IClubRepository
    {
        IQueryable<Clubs> Clubs { get; }

        Clubs AddClub(Clubs clubs);
        void UpdateClub(Clubs club);
        Clubs DeleteClub(int club);
    }
}
