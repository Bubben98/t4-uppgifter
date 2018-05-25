using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC03.Models;

namespace MVC03.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int Id)
        {
            var p = new Product()
            return View("Details");
        }
    }
}