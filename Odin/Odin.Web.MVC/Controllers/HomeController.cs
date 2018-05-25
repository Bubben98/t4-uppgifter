using Odin.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odin.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Kuben";
            return View();
        }
        [HttpGet]
        public ActionResult RSVP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RSVP(invite Invite)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", Invite);
            }
            else
            {
                return View();
            }
            
        }
    }
}