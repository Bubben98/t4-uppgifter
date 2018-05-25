using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo1.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> _product;

        public HomeController()
        {
            _product = new List<Product>();
            _product.Add(new Product() { Name = "sa", Price = 100 });
            _product.Add(new Product() { Name = "ssda", Price = 102 });
            _product.Add(new Product() { Name = "sgdga", Price = 130 });
            _product.Add(new Product() { Name = "ssfa", Price = 104 });
            _product.Add(new Product() { Name = "sjya", Price = 120 });
        }
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

        //public ActionResult Products()
        //{

        //    return View();
        //}
    }
}