using demo021017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo021017.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Hey hey";
        //}

        public ActionResult About()
        {
            return View();
        }
        public string Products()
        {
            return "list med produkter";
        }
        public ActionResult ProductInfo()
        {
            Class1 p = new Class1() { Name = "brödkniv", Price = 100 };
            return View(p);
        }
    }
}