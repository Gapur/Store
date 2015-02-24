using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using System.Web.Mvc;

namespace UnitTestApp.Managers
{
    using Store.Repositories;
    using Store.EntityModels;
    using Store.Managers;

    [TestClass]
    public class ProductManagerTest
    {
        [TestMethod]
        public void GetAllProductManagerTest()
        {
            // Arrange
            var mock = new Mock<IHostRepository>();
            BuildEntity build = new BuildEntity();
            mock.Setup(a => a.Set<Product, Store.Models.Product>(x => build.NewProductEntity(x))).Returns(new List<Store.Models.Product>());
            ProductManager productManager = new ProductManager();

            // Act
            var result = productManager.GetAllProducts().Result.ToList();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(mock.Object.Set<Product, Store.Models.Product>(x => build.NewProductEntity(x)));
            Assert.AreEqual(result, mock.Object.Set<Product, Store.Models.Product>(x => build.NewProductEntity(x)));
        }

        [TestMethod]
        public void GetProductManagerTest()
        {
            // Arrange
            var mock = new Mock<IHostRepository>();
            BuildEntity build = new BuildEntity();
            //mock.Setup(a => build.NewProductEntity(a.Entity<Product>(product => product.Id != System.Guid.Parse("f5a73537-d0ba-434e-9b08-02ff55465562"))));
            ProductManager productManager = new ProductManager();

            // Act
            var result = productManager.GetProduct(System.Guid.Parse("f5a73537-d0ba-434e-9b08-02ff55465562"));

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
