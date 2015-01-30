using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;


namespace Store.Managers
{
    using Repositories;
    using EntityModels;

    public class ProductManager
    {
        private HostRepository Repository = new HostRepository();

        public Task<IEnumerable<Models.Product>> GetAllProducts()
        {
            return Task.FromResult(Repository.Set<Product, Models.Product>(product => FileNewProduct(product)));
        }

        public Task<Models.Product> GetProduct(Guid id)
        {
            return Task.FromResult(FileNewProduct(Repository.Entity<Product>(product => product.Id == id)));
        }

        public Models.Product FileNewProduct(Product product)
        {
            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
                Color = product.Color,
                Bluetooth = (bool)product.Device.Bluetooth,
                BuildMemory = product.Device.BuildMemory,
                WiFi = (bool)product.Device.WiFi,
                Date = product.DateOfCreate,
                refManufacturers = product.Device.refManufacturer,
                refProcessor = (System.Guid)product.Device.refProcessor,
                refDicProdType = product.Device.refDicProdType,
                RAM = (int)product.Device.RAM
            };
        }
    }
}