using System.Collections.Generic;
using System.Web.Mvc;
using SoTour.Core.Models;
using SoTour.DataAccess;

namespace SoTour.UI.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            var newsRepository = new NewsRepository(new SoTourEntities());
            IEnumerable<NewsWithAuthorsViewModel> data = newsRepository.GetNews();
            return View(data);
        }
    }
}