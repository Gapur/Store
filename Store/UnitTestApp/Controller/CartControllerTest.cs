using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace UnitTestApp.Controller
{
    using Store.Repositories;
    using Store.Models;
    using Store.Controllers;
    using Store.ShoppingCart;

    [TestClass]
    public class CartControllerTest
    {
        [TestMethod]
        public void AddToCartTest()
        {
            CartController cartController = new CartController();

            bool result = cartController.AddToCart(new Cart(), new ShoppingCart());

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetTotalPriceTest()
        {
            CartController cartController = new CartController();

            decimal result = cartController.GetTotalPrice(new Cart());

            Assert.IsNotNull(result);
        }
    }
}
