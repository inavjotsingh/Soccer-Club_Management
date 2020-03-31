    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace Ashish_P_301089716.Models
    {
        public class ClubRepository : IClubRepository
        {
        public List<Clubs> Club;

        public ClubRepository()
        {
            Club= new List<Clubs>{
                new Clubs{ClubId=1, NameOfClub = "Barcelona" , NameOfCoach = "Quique Setien" , StadiumCapacity = 99354,
                    NumberOfPlayers = 20 , President = "Josep Maria Bartomeu", LeagueParticipated = "la liga",
                },
                new Clubs {ClubId=2, NameOfClub = "Arsenal" , NameOfCoach = "Mikel Arteta" , StadiumCapacity = 60704,
                    NumberOfPlayers = 22, President = "Sir Chips Keswick", LeagueParticipated = "Premier Leagues",
                },
            };
        }
        public IQueryable<Clubs> Clubs => Club.AsQueryable<Clubs>();
            
        public Clubs AddClub(Clubs clubs)
        {
            Club.Add(clubs);
            return clubs;
        }

        public void DeleteClub(Clubs club)
        {
            throw new NotImplementedException();
        }

        public Clubs DeleteClub(int club)
        {
            throw new NotImplementedException();
        }

        public Clubs UpdateClub(Clubs club)
        {
            throw new NotImplementedException();
        }

        void IClubRepository.UpdateClub(Clubs club)
        {
            throw new NotImplementedException();
        }
    }
    }
