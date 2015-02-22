using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace Store.Controllers
{
    using ShoppingCart;
    using Managers;

    /// <summary>
    /// Check controller
    /// </summary>  
    public class CheckController : Controller
    {
        CheckManager checkManager = new CheckManager();

        /// <summary>
        /// The method returns check
        /// </summary>  
        /// <param name="cart">shopping cart of user</param>
        /// <returns>return ActionResult</returns>
        public ActionResult Check(Cart cart)
        {
            return View();
        }

        /// <summary>
        /// The method adds a check to the order
        /// </summary>  
        /// <param name="cart">shopping cart</param>
        /// <param name="check">check user</param>
        /// <returns>return bool</returns>
        [HttpPost]
        public async Task<bool> EntryCheck(Cart cart, Models.Check check)
        {
            if (ModelState.IsValid)
            {
                string userId = User.Identity.GetUserId();
                check.refUser = userId;
                bool result = await checkManager.EntryCheck(cart, check);
                return result;
            }
            return false;
        }

        /// <summary>
        /// The method returns all orders by user of Id
        /// </summary>  
        /// <param name="userId">ID user</param>
        /// <returns>return ActionResult</returns>
        [HttpGet]
        public async Task<ActionResult> EntryCheck()
        {
            IEnumerable<Models.Check> checks = await checkManager.GetUserChecks(User.Identity.GetUserId());
            return View(checks.ToList());
        }

        /// <summary>
        /// The method deletes order from check
        /// </summary>  
        /// <param name="check">check user</param>
        /// <returns>return true or false</returns>
        public async Task<bool> DeleteCheck(Models.Check check)
        {
            bool result = await checkManager.DeleteCheck(check);
            return result;
        }

        /// <summary>
        /// The method returns all orders from checks
        /// </summary>  
        /// <returns>return Task ActionResult</returns>
        public async Task<ActionResult> Orders()
        {
            IEnumerable<Models.Check> orders = await checkManager.GetAllChecks();
            return View(orders);
        }
    }
}