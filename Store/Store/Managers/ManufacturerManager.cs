using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Store.Managers
{
    using Repositories;
    using EntityModels;

    public class ManufacturerManager
    {
        private HostRepository Repository = new HostRepository();

        public ManufacturerManager()
        {
        }

        public Task<Manufacturer> GetManufacturer()
        {
            return Task.FromResult(Repository.Entity<Manufacturer>(manufacturer => manufacturer.Id == 1));
        }

        public void Dispose()
        {
        }
    }
}