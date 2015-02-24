using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestApp.ShoppingCart
{
    using Store.Models;
    using Store.ShoppingCart;

    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void AddNewItemTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 30000 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 40000 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 1);
            cart.AddItem(cart2, 1);
            List<CartLine> result = cart.Lines.ToList();

            //Assert
            Assert.AreEqual(result.Count(), 2);
            Assert.AreEqual(result[0].ShoppingCart, cart1);
            Assert.AreEqual(result[1].ShoppingCart, cart2);
        }

        [TestMethod]
        public void AddQuentityForExistingItemTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 30000 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 40000 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 1);
            cart.AddItem(cart2, 1);
            cart.AddItem(cart2, 3);
            List<CartLine> result = cart.Lines.OrderBy(el => el.ShoppingCart.Id).ToList();

            //Assert
            Assert.AreEqual(result.Count(), 2);
            Assert.AreEqual(result[0].Quantity, 1);
            Assert.AreEqual(result[1].Quantity, 4);
        }

        [TestMethod]
        public void AddRemoveItemTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 30000 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 40000 };
            ShoppingCart cart3 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungDuos", Price = 5000 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 1);
            cart.AddItem(cart2, 1);
            cart.AddItem(cart3, 2);
            cart.AddItem(cart1, 4);
            cart.AddItem(cart3, 1);
            cart.RemoveLine(cart2.Id);

            //Assert
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart == cart2).Count(), 0);
            Assert.AreEqual(cart.Lines.Count(), 2);
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart.Id == cart3.Id).ToList()[0].Quantity, 3);
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart == cart1).Count(), 1);
        }

        [TestMethod]
        public void CalculateTotalPriceTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 3 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 4 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 1);
            cart.AddItem(cart2, 1);
            cart.AddItem(cart2, 8);
            decimal result = cart.ComputeTotalValue();

            //Assert
            Assert.AreEqual(result, 39);
        }

        [TestMethod]
        public void ClearCartListTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 3 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 4 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 1);
            cart.AddItem(cart2, 1);
            cart.AddItem(cart2, 8);
            cart.Clear();

            //Assert
            Assert.AreEqual(cart.Lines.Count(), 0);
        }

        [TestMethod]
        public void ModifiedCartQuentityTest()
        {
            //Arrange
            ShoppingCart cart1 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS4", Price = 3 };
            ShoppingCart cart2 = new ShoppingCart { Id = System.Guid.NewGuid(), ImageUrl = "img", Name = "SamsungS5", Price = 4 };

            //Act
            Cart cart = new Cart();
            cart.AddItem(cart1, 3);
            cart.AddItem(cart2, 1);
            cart.AddItem(cart2, 8);
            cart.ModifiedItemCart(cart1.Id, "-");
            cart.ModifiedItemCart(cart2.Id, "+");

            //Assert
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart.Id == cart1.Id).ToList()[0].Quantity, 2);
            Assert.AreEqual(cart.Lines.Where(l => l.ShoppingCart.Id == cart2.Id).ToList()[0].Quantity, 10);
        }
    }
}
