using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U021017.Models;

namespace U021017.Controllers
{
    public class HomeController : Controller
    {

       
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Product()
        {
            List<Products> p = new List<Products>();
            p.Add(new Products() { Name = "hej", Price = 100, Category = "A" });
            p.Add(new Products() { Name = "tja", Price = 10, Category = "A" });
            p.Add(new Products() { Name = "tjo", Price = 120, Category = "B" });
            p.Add(new Products() { Name = "tjena", Price = 110, Category = "A" });
            p.Add(new Products() { Name = "hejsan", Price = 106, Category = "B" });

            
            return View(p);
        }



    }
}