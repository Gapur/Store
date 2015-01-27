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

        public Task<IEnumerable<Manufacturer>> GetAllManufacturer()
        {
            return Task.FromResult(Repository.Set<Manufacturer>(manufacturer => manufacturer.Id != null));
        }

        public void Dispose()
        {
        }
    }
}