using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Collections.Generic;

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
        public void AddToNewCartTest()
        {
            CartController cartController = new CartController();
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 3 };

            bool result = cartController.AddToCart(new Cart(), cart1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetTotalPriceTest()
        {
            CartController cartController = new CartController();

            decimal result = cartController.GetTotalPrice(new Cart());

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RemoveCartFromListTest()
        {
            CartController cartController = new CartController();
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 3 };

            Cart cart = new Cart();
            cart.AddItem(cart1, 3);
            bool result = cartController.RemoveFromCart(new Cart(), cart1.Id);

            Assert.IsTrue(result);
            Assert.AreEqual(cart.Lines.Count(), 1);
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart.Id == cart1.Id).Count(), 1);
        }
    }
}
