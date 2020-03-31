using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashish_P_301089716.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ashish_P_301089716.Controllers
{
    public class ClubsController : Controller
    {
        IClubRepository repository;
        public ClubsController(IClubRepository clubRepository)
        {
            repository = clubRepository;
        }
        public ViewResult Clubs()
        {
            return View(repository.Clubs);
        }

        public ViewResult ManageClubs(int clubID)
        {
            return View(repository.Clubs.FirstOrDefault(o=>o.ClubId == clubID));
        }

        public ViewResult AddClubPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddClubPage(Clubs clubs)
        {
            repository.AddClub(clubs);
            return RedirectToAction(nameof(Clubs));
        }

        public ViewResult UpdateClub(int clubId)
        {
            return View(repository.Clubs.FirstOrDefault(a => a.ClubId == clubId));
        }
        
    }
}