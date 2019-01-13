using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class TripsController : Controller
    {
        // GET: Trips
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index(string p)
        {
            ViewBag.DisplayName = p;
            return View();
        }

        //[Route("Trips/SearchTrip/{searchParam}")]
        public ActionResult SearchTrip(string searchParam)
        {
            return View("SearchTripResults");
        }

        public ActionResult Calcutta()
        {
            return View();
        }

        public ActionResult Crafts()
        {
            return View();
        }

        public ActionResult Festivals()
        {
            return View();
        }

        //Voluntourism
        public ActionResult Voluntourism()
        {
            return View();
        }

        public ActionResult Workshops()
        {
            return View();
        }
    }
}