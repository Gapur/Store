using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Store.Managers
{
    using Repositories;
    using EntityModels;

    /// <summary>
    /// Check manager
    /// </summary>  
    public class CheckManager
    {
        HostRepository repository = new HostRepository();
        BuildEntity buildEntity = new BuildEntity();

        /// <summary>
        /// The method creates a new check product orders
        /// </summary>  
        /// <param name="cart">shopping cart user</param>
        /// <param name="check">check user</param>
        /// <returns></returns>
        public Task<bool> EntryCheck(ShoppingCart.Cart cart, Models.Check check)
        {
            IEnumerable<EntityModels.Check> entityModelsChecks = cart.Lines.Select(c => buildEntity.EntityModelsCheck(check, c.ShoppingCart.Id, c.Quantity));
            return Task.FromResult(repository.Add(entityModelsChecks));
        }

        /// <summary>
        /// The method returns check by userID
        /// </summary>  
        /// <param name="userId">ID user</param>
        /// <returns>return IEnumerable Models.Check</returns>
        public Task<IEnumerable<Models.Check>> GetUserChecks(string userId)
        {
            return Task.FromResult(repository.Set<Check>(check => check.refUser == userId).Select(c => buildEntity.NewCheck(c)));
        }

        /// <summary>
        /// the method returns all checks
        /// </summary>  
        /// <returns>IEnumerable Models.Check</returns>
        public Task<IEnumerable<Models.Check>> GetAllChecks()
        {
            return Task.FromResult(repository.Set<Check, Models.Check>(check => buildEntity.NewCheck(check)));
        }

        /// <summary>
        /// The method deletes check from database
        /// </summary>  
        /// <param name="check">Models.Check check</param>
        /// <returns></returns>
        public Task<bool> DeleteCheck(Models.Check check)
        {
            return Task.FromResult(repository.Delete<EntityModels.Check>(buildEntity.EntityModelsCheck(check)));
        }
    }
}