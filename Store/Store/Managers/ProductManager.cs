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

        public Task<IEnumerable<Models.Product>> GetFilterProducts(int type)
        {
            return Task.FromResult(Repository.Set<Product>(product => product.Device.refDicProdType == type).Select(prod => NewProductEntity(prod)));
        }

        public Models.Product NewProductEntity(Product product)
        {
            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
                Color = product.Color,
                Price = product.Price,
                Date = product.DateOfCreate,
                Bluetooth = (product.Device.Bluetooth == null ? false : (bool)product.Device.Bluetooth),
                BuildMemory = (product.Device.BuildMemory == null ? String.Empty : product.Device.BuildMemory),
                WiFi = (product.Device.WiFi == null ? false : (bool)product.Device.WiFi),
                Manufacturers = NewManufacturerEntity(product.Device.Manufacturer),
                refDicProdType = product.Device.refDicProdType,
                RAM = (product.Device.RAM == null ? 0 : (int)product.Device.RAM),
                Images = (IEnumerable<Models.Image>)product.Device.Images.Select(img => NewImageEntity(img)),
                Processor = product.Device.refProcessor == null ? null : NewProcessorEntity(product.Device.Processor),
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

        public Models.Manufacturer NewManufacturerEntity(Manufacturer manufacturer)
        {
            return new Models.Manufacturer
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                Country = manufacturer.Country
            };
        }

        public Models.Processor NewProcessorEntity(Processor processor)
        {
            return new Models.Processor
            {
                Id = processor.Id,
                Type = processor.Type,
                ClockSpeed = processor.ClockSpeed,
                CountCore = processor.CountCore
            };
        }

        private enum DictionaryProductType
        {
            Phone = 1,
            Notebook,
            TV
        }
    }
}