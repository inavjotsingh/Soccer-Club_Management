using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashish_P_301089716.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ashish_P_301089716.Controllers
{
    public class PlayersController : Controller
    {
        IPlayerRepository repository;
        IClubRepository crepos;
        public PlayersController(IPlayerRepository repo, IClubRepository repos)
        {
            repository = repo;
            crepos = repos;
        }
        public ViewResult ManagePlayers(Player player)
        {
            ViewData["clubs"] = crepos.Clubs;
            
            return View(repository.Players);
        }

        [HttpPost]
        public IActionResult AssignClubtoPlayer(int clubId, int playerId)
        {
            repository.UpdatePlayer(playerId, clubId);
            return RedirectToAction("ManagePlayers", new { player = repository.Players.FirstOrDefault(a=>a.PlayerId == playerId)});
            
        }
    }
}