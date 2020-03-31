using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashish_P_301089716.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
                    new Clubs
                    {
                        NameOfClub = "Barcelona",
                        NameOfCoach = "Mikel Arteta",
                        StadiumCapacity = 110000,
                        NumberOfPlayers = 15,
                        President = "KSE, UK, Inc.",
                        LeagueParticipated = "Premier League, UEFA Champions League, FA Cup, UEFA Europa League, EFL Cup"
                    }, new Clubs
                    {
                        NameOfClub = "Arsenal",
                        NameOfCoach = "Quique Setién",
                        StadiumCapacity = 99354,
                        NumberOfPlayers = 15,
                        President = "Josep Maria Bartomeu",
                        LeagueParticipated = "Premier League, UEFA Champions League, FA Cup, UEFA Europa League, EFL Cup"
                    }, new Clubs
                    {
                        NameOfClub = "Manchester City F.C.",
                        NameOfCoach = "Pep Guardiola",
                        StadiumCapacity = 150000,
                        NumberOfPlayers = 15,
                        President = " Ferran Soriano",
                        LeagueParticipated = "Premier League, UEFA Champions League, FA Cup, UEFA Europa League, EFL Cup"
                    }, new Clubs
                    {
                        NameOfClub = "Liverpool F.C.",
                        NameOfCoach = "Jürgen Klopp",
                        StadiumCapacity = 125000,
                        NumberOfPlayers = 15,
                        President = "Anfield",
                        LeagueParticipated = "Premier League, UEFA Champions League, FA Cup, UEFA Europa League, EFL Cup"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Players.Any())
            {
                context.Players.AddRange(
                    new Player
                    {
                        Name = "leonal messi",
                        Nationality = "spain",
                        age = 30,
                        MatchPlayer = 300,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a=>a.ClubId==1)
                    }, new Player
                    {
                        Name = "Cristiano Ronaldo",
                        Nationality = "Portugal ",
                        age = 35,
                        MatchPlayer = 354,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 1)
                    }, new Player
                    {
                        Name = "Neymar",
                        Nationality = "Brazil ",
                        age = 28,
                        MatchPlayer = 154,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 2)
                    }, new Player
                    {
                        Name = "Zlatan Ibrahimović",
                        Nationality = "Sweden ",
                        age = 35,
                        MatchPlayer = 244,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 2)
                    }, new Player
                    {
                        Name = "Ronaldinho",
                        Nationality = "Brazil ",
                        age = 38,
                        MatchPlayer = 454,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 3)
                    }, new Player
                    {
                        Name = "Cristiano Ronaldo",
                        Nationality = "Portugal ",
                        age = 35,
                        MatchPlayer = 304,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 3)
                    }, new Player
                    {
                        Name = "Luis Suárez",
                        Nationality = "Uruguaya ",
                        age = 33,
                        MatchPlayer = 314,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId ==4 )
                    }, new Player
                    {
                        Name = "David Beckham",
                        Nationality = "England ",
                        age = 38,
                        MatchPlayer = 254,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 4)
                    }, new Player
                    {
                        Name = "Gareth Bale",
                        Nationality = "Spain ",
                        age = 25,
                        MatchPlayer = 114,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 1)
                    }, new Player
                    {
                        Name = "Sergio Ramos",
                        Nationality = "Spain ",
                        age = 27,
                        MatchPlayer = 324,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 2)
                    }, new Player
                    {
                        Name = "David Silva",
                        Nationality = "Spain ",
                        age = 30,
                        MatchPlayer = 310,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 3)
                    }, new Player
                    {
                        Name = "Dele Alli",
                        Nationality = "England ",
                        age = 26,
                        MatchPlayer = 300,
                        DateOfBirth = DateTime.Today,
                        Club = context.Clubs.First(a => a.ClubId == 4)
                    }) ;
                context.SaveChanges();
            }

        }
    }
}
