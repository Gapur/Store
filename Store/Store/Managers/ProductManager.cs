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
            return Task.FromResult(Repository.Set<Product, Models.Product>(product => NewProductEntity(product)));
        }

        public Task<Models.Product> GetProduct(Guid id)
        {
            return Task.FromResult(NewProductEntity(Repository.Entity<Product>(product => product.Id == id)));
        }

        public Models.Product NewProductEntity(Product product)
        {
            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
                Color = product.Color,
                Price = product.Price,
                Bluetooth = (bool)product.Device.Bluetooth,
                BuildMemory = product.Device.BuildMemory,
                WiFi = (bool)product.Device.WiFi,
                Date = product.DateOfCreate,
                refManufacturers = product.Device.refManufacturer,
                refProcessor = (System.Guid)product.Device.refProcessor,
                refDicProdType = product.Device.refDicProdType,
                RAM = (int)product.Device.RAM,
                Images = (IEnumerable<Models.Image>)product.Device.Images.Select(img => NewImageEntity(img))
            };
        }

        public Models.Image NewImageEntity(Image image)
        {
            return new Models.Image
            {
                Id = image.Id,
                Url = image.Url,
                refDevice = image.refDevice
            };
        }
    }
}