using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teeba.Models;

namespace Teeba.Controllers
{
    public class AswanController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            var aswanplaces = context.AsswanPlaces.ToList();
            return View(aswanplaces);
        }
        public ActionResult AsswanPlacesForHome()
        {
            var places = context.AsswanPlaces.Take(3).ToList();
            return PartialView("_AsswanPlaces", places);
        }
        public ActionResult PlaceDetails(int id)
        {
            var place = context.AsswanPlaces.FirstOrDefault(m => m.ID == id);
            ViewBag.Places = context.AsswanPlaces.ToList();
            return View(place);
        }
        public ActionResult Translate(int id)
        {
            var ArabicDescribtion = (from m in context.AsswanPlaces
                                     where m.ID == id
                                     select m.Arabic_Long_Describtion).FirstOrDefault();
            return Content(ArabicDescribtion);
        }
    }
}