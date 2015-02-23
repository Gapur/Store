using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    using ShoppingCart;
    using Models;

    /// <summary>
    /// Cart controller
    /// </summary>  
    [Authorize]
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

        /// <summary>
        /// The method adds a cart in list
        /// </summary>  
        /// <param name="cart">session cart</param>
        /// <param name="shopingCart">shopping cart</param>
        /// <returns>return bool</returns>
        public bool AddToCart(Cart cart, ShoppingCart shopingCart)
        {
            return cart.AddItem(shopingCart, 1);
        }

        /// <summary>
        /// The method deletes a cart from list of session
        /// </summary>  
        /// <param name="cart">session cart</param>
        /// <param name="productId">product Id</param>
        /// <returns>return bool</returns>
        public bool RemoveFromCart(Cart cart, System.Guid productId)
        {
            return productId != null ? cart.RemoveLine(productId) : false;
        }

        /// <summary>
        /// The method modified quentity of product from cart 
        /// </summary>  
        /// <param name="cart">shopping cart</param>
        /// <param name="productId">product Id</param>
        /// <param name="mark">mark(minus or plus)</param>
        /// <returns>return bool</returns>
        public bool ModifiedItemCart(Cart cart, System.Guid productId, string mark)
        {
            return cart.ModifiedItemCart(productId, mark);
        }

        /// <summary>
        /// The method returns total price
        /// </summary>  
        /// <param name="cart">shopping cart</param>
        /// <returns>return decimal</returns>
        public decimal GetTotalPrice(Cart cart)
        {
            return cart.ComputeTotalValue();
        }

        /// <summary>
        /// The method clear all products of cart list
        /// </summary>  
        /// <param name="cart">shopping cart</param>
        /// <returns></returns>
        public void ClearCart(Cart cart)
        {
            cart.Clear();
        }
    }
}