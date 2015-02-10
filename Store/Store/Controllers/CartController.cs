using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    using ShoppingCart;
    using Models;

    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cart(Cart cart)
        {
            return View(new CartIndexViewModel
                {
                    Cart = cart,
                });
        }

        public bool AddToCart(Cart cart, ShoppingCart shopingCart)
        {
            cart.AddItem(shopingCart, 1);
            return true;
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, System.Guid productId)
        {
            cart.RemoveLine(productId);
            return RedirectToAction("Index");
        }
    }
}