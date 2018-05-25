using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _061117.Models;
using _061117.Controllers;
using System.Net.Http;

namespace _061117.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var MyApiURL = Url.RouteUrl(
                "DefaultApi",
                new { httproute = "", controller = "Product" },
                Request.Url.Scheme
                    );

            var model = new HttpClient()
                .GetAsync(MyApiURL)
                .Result
                .Content.ReadAsAsync<IEnumerable<Class1>>().Result;

            return View(model);
        }
        
    }
}