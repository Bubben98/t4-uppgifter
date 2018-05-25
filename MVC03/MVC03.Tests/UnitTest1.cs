using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC03.Controllers;
using System.Web.Mvc;

namespace MVC03.Tests
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(42) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }
        [TestMethod]
        public void TestDetailsViewData()
        {
            var controller = new ProductController();
            var result = controller.Details(42) as ViewResult;
            var 
            Assert.AreEqual("kockkniv", Prod.Name);
        }
    }
}
