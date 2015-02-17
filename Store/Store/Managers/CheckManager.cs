using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Store.Managers
{
    using Repositories;

    /// <summary>
    /// Check manager
    /// </summary>  
    public class CheckManager
    {
        HostRepository repository = new HostRepository();
        BuildEntity buildEntity = new BuildEntity();

        /// <summary>
        /// Метод cоздает пользователя с указанным паролем.
        /// </summary>  
        /// <param name="userName">Имя пользователя</param>
        /// <param name="email"></param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>возвращает IdentityResult</returns>
        public Task EntryCheck(ShoppingCart.Cart cart, Models.Check check)
        {
            IEnumerable<EntityModels.Check> entityModelsChecks = cart.Lines.Select(c => buildEntity.EntityModelsCheck(check, c.ShoppingCart.Id, c.Quantity));
            return Task.FromResult(repository.Add(entityModelsChecks));
        }
    }
}