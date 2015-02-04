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
        private BuildEntity buildEntity = new BuildEntity();

        public Task<IEnumerable<Models.Product>> GetAllProducts()
        {
            return Task.FromResult(Repository.Set<Product, Models.Product>(product => buildEntity.NewProductEntity(product)));
        }

        public Task<Models.Product> GetProduct(Guid id)
        {
            return Task.FromResult(buildEntity.NewProductEntity(Repository.Entity<Product>(product => product.Id == id)));
        }

        public Task<IEnumerable<Models.Product>> GetFilterProducts(int type)
        {
            return Task.FromResult(Repository.Set<Product>(product => product.Device.refDicProdType == type).Select(
                prod => buildEntity.NewProductEntity(prod)));
        }

    }
}