using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace UnitTestApp.Controller
{
    using Store.Repositories;
    using Store.Models;
    using Store.Controllers;

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void AboutViewEqualCshtml()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void AboutViewEqualNotNull()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ContactViewEqualCshtml()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Contact() as ViewResult;

            Assert.AreEqual("Contact", result.ViewName);
        }

        [TestMethod]
        public void DetailProductEqualNotNull()
        {
            HomeController controller = new HomeController();

            PartialViewResult result = controller.DetailProduct(new Product()) as PartialViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateFolderIfNeeded()
        {
            HomeController controller = new HomeController();

            bool result = controller.CreateFolderIfNeeded("~/Content/img");

            Assert.IsTrue(result);
        }
    }
}
