using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashish_P_301089716.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ashish_P_301089716.Controllers
{
    public class CRUDController : Controller
    {
        IClubRepository clubrepository;

        public CRUDController(IClubRepository repo)
        {
            clubrepository = repo;
        }
        public ViewResult UpdateClub(int clubId)
        {
            return View(clubrepository.Clubs.FirstOrDefault(a => a.ClubId == clubId));
        }

        [HttpPost]
        public IActionResult UpdateClub(Clubs clubs)
        {
            clubrepository.UpdateClub(clubs);
            return RedirectToAction("ManageClubs",new {cludId = clubs.ClubId });
        }

        public RedirectToActionResult DeleteClub(int clubId)
        {
            Clubs dclub = clubrepository.DeleteClub(clubId);
            if (dclub != null)
            {
                TempData["message"] = $"{dclub.NameOfClub} has been deleted!";
            }
            return RedirectToAction("Clubs");
        }

    }
}