using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teeba.Models;

namespace Teeba.Controllers
{
    public class ToursController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            var tours = context.Tours.ToList();
            return View(tours);
        }
        public ActionResult TourDetails(int id)
        {
            var tour = context.Tours.FirstOrDefault(m => m.ID == id);
            ViewBag.Price = (tour.Price * 90)/100; 
            return View(tour);
        }
        public ActionResult LuxorProgram()
        {
            return PartialView("_LuxorProgram");
        }
        
    }
}