using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Store.Controllers
{
    using ShoppingCart;
    using Managers;

    public class CheckController : Controller
    {
        CheckManager checkManager = new CheckManager();

        public ActionResult Check(Cart cart)
        {
            return View();
        }

        public ActionResult EntryCheck(Cart cart, Models.Check check)
        {
            string userId = User.Identity.GetUserId();
            checkManager.EntryCheck(cart, check);
            return View();
        }
    }
}