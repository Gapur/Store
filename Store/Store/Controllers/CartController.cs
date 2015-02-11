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
            return cart.AddItem(shopingCart, 1);
        }

        public bool RemoveFromCart(Cart cart, System.Guid productId)
        {
            return productId != null ? cart.RemoveLine(productId) : false;
        }

        public bool ModifiedItemCart(Cart cart, System.Guid productId, string mark)
        {
            return cart.ModifiedItemCart(productId, mark);
        }

        public decimal GetTotalPrice(Cart cart)
        {
            return cart.ComputeTotalValue();
        }
    }
}