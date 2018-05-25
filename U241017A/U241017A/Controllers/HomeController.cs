using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U241017A.DATA;

namespace U241017A.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bookings()
        {
            return View(_repo.Products);
        }
        [HttpGet]
        public ActionResult newBooking()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult newBooking(Product p)
        {
            _repo.Add(p);
            return RedirectToAction("Bookings");
        }

        [HttpGet]
        public ActionResult dBooking(int id)
        {
            Booking b = _repo.Bookings.Find(x => x.Id == id);
            return b;
        }
    }
}
