using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoTour.Core;
using SoTour.DataAccess;

namespace SoTour.UI.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            var datasource = new ModelSoTour();
            var dataAccess = new PlayerAccess();
            string playerName ="Jugador";
            IEnumerable<Player> data = datasource.GetPlayer();
            return View(data);
        }
    }
}