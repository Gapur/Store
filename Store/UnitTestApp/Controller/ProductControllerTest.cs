using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using System.Web.Http.Results;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestApp.Controller
{
    using Store.Controllers;
    using Store.Models;
    using Store.Managers;

    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetAllProductTest()
        {
            ProductsController productController = new ProductsController();

            var result = productController.GetProducts();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetProductTest()
        {
            ProductsController productController = new ProductsController();
            Product prod = new Product { Id = System.Guid.NewGuid() };

            var result = productController.GetProduct(prod.Id);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetFilterProductTest()
        {
            ProductsController productController = new ProductsController();
            Product prod = new Product { TypeProduct = 1 };

            var result = productController.GetFilterProducts(prod.TypeProduct);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostProductTest()
        {
            ProductsController productController = new ProductsController();
            Product prod = new Product { Id = System.Guid.NewGuid(), TypeProduct = 1 };

            var result = productController.PostProduct(prod);

            Assert.IsNotNull(result);
        }
    }
}
