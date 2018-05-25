using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _061117.Models;

namespace _061117.Controllers
{
    public class ProductController : ApiController
    {
        private List<Class1> prod = new List<Class1>();
        [HttpGet]
        public List<Class1> Products()
        {
            return prod;
        }

        public ProductController()
        {
            prod.Add(new Class1() { Name = "1", Event = "s", Place = "d f", Time = "2013", Id = 10 });
            prod.Add(new Class1() { Name = "2", Event = "d", Place = "j d", Time = "2010", Id = 20 });
            prod.Add(new Class1() { Name = "3", Event = "f", Place = "y u", Time = "2015", Id = 30 });
            prod.Add(new Class1() { Name = "4", Event = "s", Place = "f j", Time = "2017", Id = 40 });
            prod.Add(new Class1() { Name = "5", Event = "d", Place = "d v", Time = "2018", Id = 50 });
        }
    }
    
}
