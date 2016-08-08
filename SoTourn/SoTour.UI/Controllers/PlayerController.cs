using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoTour.Core;
using SoTour.DataAccess;
using log4net;
using SoTour.UI.PlayerServiceReference;
namespace SoTour.UI.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ILog log = LogManager.GetLogger(typeof(PlayerController));

        //[HandleError(ExceptionType = typeof(ArithmeticException), View = "Arthimetic")]
        //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "Divide By Zero")]

        //[HandleError()]
        public ActionResult Index(string playerName)
        {

            try
            {
                var cliente = new PlayerServiceClient();

                var emptyValue = string.Empty;
                if (!string.IsNullOrEmpty(playerName))
                {
                    var viewPlayerInformation = cliente.GetPlayer(playerName);
                    return View(viewPlayerInformation);
                }

                var viewFullPlayerInformation = cliente.GetPlayer(emptyValue);
   
                return View(viewFullPlayerInformation);
            }
            catch (Exception e)
            {
                //Exception exception = Server.GetLastError();
                //Server.ClearError();
                //Response.Redirect("/Home/Error");

                //throw new Exception("PlayerError");
                log.Debug(e.Message);
                return View("Error");
            }
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    Exception ex = filterContext.Exception;
        //    filterContext.ExceptionHandled = true;

        //    var model = new HandleErrorInfo(filterContext.Exception, "Player", "Index");

        //    filterContext.Result = new ViewResult()
        //    {
        //        ViewName = "Error",
        //        ViewData = new ViewDataDictionary(model)
        //    };

        //}
    }

}