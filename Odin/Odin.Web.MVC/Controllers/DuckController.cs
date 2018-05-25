using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odin.Web.MVC.Controllers
{
    public class DuckController : Controller
    {
        // GET: Duck
        public ActionResult Index()
        {
            return View();
        }
    }
}