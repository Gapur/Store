using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;


namespace Store.Managers
{
    using Repositories;
    using EntityModels;

    /// <summary>
    /// Product manager
    /// </summary>
    public class ProductManager
    {
        private IHostRepository Repository = new HostRepository();
        private BuildEntity buildEntity = new BuildEntity();

        /// <summary>
        /// the method returns all products
        /// </summary>
        /// <returns>all IEnumerable products</returns>
        public Task<IEnumerable<Models.Product>> GetAllProducts()
        {
            return Task.FromResult(Repository.Set<Product, Models.Product>(product => buildEntity.NewProductEntity(product)));
        }

        /// <summary>
        /// the method returns product by id
        /// </summary>
        /// <param name="id">id product</param>
        /// <returns>return models product</returns>
        public Task<Models.Product> GetProduct(Guid id)
        {
            return Task.FromResult(buildEntity.NewProductEntity(Repository.Entity<Product>(product => product.Id == id)));
        }

        /// <summary>
        /// the method than filters products
        /// </summary>
        /// <param name="type">type product</param>
        /// <returns>return IEnumerable product</returns>
        public Task<IEnumerable<Models.Product>> GetFilterProducts(int type)
        {
            return Task.FromResult(Repository.Set<Product>(product => product.Device.refDicProdType == type).Select(
                prod => buildEntity.NewProductEntity(prod)));
        }

        /// <summary>
        /// the method returns the properties of the product
        /// </summary>
        /// <returns>Models.BaseEntity product</returns>
        public Task<Models.BaseEntity> GetProductProperty()
        {
            Models.BaseEntity entities = new Models.BaseEntity();
            entities.ManufacturerList = Repository.Set<Manufacturer>(m => m != null);
            entities.CameraList = Repository.Set<Camera>(camera => camera != null);
            entities.HardDiskList = Repository.Set<HardDisk>(disk => disk != null);
            entities.ProcessorList = Repository.Set<Processor>(pro => pro != null);
            entities.OperSystemList = Repository.Set<OperatingSystem>(sys => sys != null);
            entities.VideoCardList = Repository.Set<VideoCard>(videoCard => videoCard != null);
            entities.DisplayList = Repository.Set<Display>(dis => dis != null);
            entities.PowerList = Repository.Set<Power>(power => power != null);
            return Task.FromResult(entities);
        }

        /// <summary>
        /// the method creates new product
        /// </summary>
        /// <param name="product">New product</param>
        /// <returns></returns>
        public Task<bool> CreateProduct(Models.Product product)
        {
            System.Guid ID = System.Guid.NewGuid();
            Device device = buildEntity.EntityModelsDevice(product, ID);
            Product prod = buildEntity.EntityModelsProduct(product, ID);
            Image img = new Image
            {
                Url = "/Content/img/" + Path.GetFileName(product.Images.Url),
                refDevice = ID,
            };
            return Task.FromResult(Repository.Add(prod, device, img));
        }

        /// <summary>
        /// The method deletes product from database
        /// </summary>  
        /// <param name="check">Models.Check check</param>
        /// <returns></returns>
        public Task<bool> DeleteProduct(Models.Product product)
        {
            Device device = new Device { Id = product.Id };
            Image image = new Image { Id = product.Images.Id };
            Product prod = new Product { Id = product.Id };
            return Task.FromResult(Repository.Delete(prod, device, image));
        }
    }
}