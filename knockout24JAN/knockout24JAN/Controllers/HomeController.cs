using knockout24JAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace knockout24JAN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = new[] {
                new wishList() {Title="AAA", Price= 100},
                new wishList() {Title="bbb", Price= 200}
            };
            return View(data);
        }
    }
}