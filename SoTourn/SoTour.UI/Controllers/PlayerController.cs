using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoTour.Core;
using SoTour.DataAccess;

namespace SoTour.UI.Controllers
{
    public class PlayerController : Controller
    {
        ModelSoTour datasource = new ModelSoTour();

        // GET: Player
        public ActionResult SearchPlayer(string playerName)
        {
         
            var players = from s in datasource.Player select s;
            if (!String.IsNullOrEmpty(playerName))
            {
                players = players.Where(s => s.Name.Contains(playerName));
            }

            
            //var dataAccess = new PlayerAccess();
          
            //IEnumerablek<Player> data = datasource.GetPlayer();
            return View(players);
        }
    }
}