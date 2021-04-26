using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teeba.Models;

namespace Teeba.Controllers
{
    public class LuxorController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Luxor
        public ActionResult Index()
        {
            var luxorplaces = context.LuxorPlaces.ToList();
            return View(luxorplaces);
        }

        public ActionResult LuxorPlacesForHome()
        {
            var places = context.LuxorPlaces.Take(3).ToList();
            return PartialView("_LuxorPlaces", places);
        }
        public ActionResult PlaceDetails(int id)
        {
            var place = context.LuxorPlaces.FirstOrDefault(m => m.ID == id);
            ViewBag.Places = context.LuxorPlaces.ToList();
            return View(place);
        }
        public ActionResult Translate(int id)
        {
            var ArabicDescribtion = (from m in context.LuxorPlaces
                                    where m.ID == id
                                    select m.Arabic_Long_Describtion).FirstOrDefault();
            return Content(ArabicDescribtion);
        }
    }
}