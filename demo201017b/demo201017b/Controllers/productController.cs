﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo201017b.Controllers
{
    public class productController : ApiController
    {
        public String GETProduct()
        {
            return "Product a";
        }
    }
}
