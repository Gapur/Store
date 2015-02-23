/*
 * Created by: Kassym Gapur
 * Created: 10.02.2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.ShoppingCart
{
    using Models;

    /// <summary>
    /// Cart class
    /// </summary>  
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        /// <summary>
        /// The method adds a new cart in list of cartline 
        /// </summary>  
        /// <param name="cart">shopping cart</param>
        /// <param name="quantity">item quantity</param>
        /// <returns>return bool</returns>
        public bool AddItem(ShoppingCart cart, int quantity)
        {
            try
            {
                CartLine line = lineCollection
                    .Where(g => g.ShoppingCart.Id == cart.Id)
                    .FirstOrDefault();

                if (line == null)
                {
                    lineCollection.Add(new CartLine
                    {
                        ShoppingCart = cart,
                        Quantity = quantity
                    });
                }
                else
                {
                    line.Quantity += quantity;
                }
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        /// <summary>
        /// The method removes the item by id
        /// </summary>  
        /// <param name="id">cart id</param>
        /// <returns>return bool</returns>
        public bool RemoveLine(System.Guid Id)
        {
            try
            {
                lineCollection.RemoveAll(l => l.ShoppingCart.Id == Id);
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        /// <summary>
        /// The method modified item cart
        /// </summary>  
        /// <param name="id">cart id</param>
        /// <param name="mark">minus or plus</param>
        /// <returns>return bool</returns>
        public bool ModifiedItemCart(System.Guid Id, string mark)
        {
            try
            {
                CartLine line = lineCollection
                   .Where(g => g.ShoppingCart.Id == Id)
                   .FirstOrDefault();
                if (line != null)
                {
                    if (mark.Equals("-"))
                        line.Quantity--;
                    else line.Quantity++;
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        /// <summary>
        /// The method calculates total price of shopping cart
        /// </summary>  
        /// <returns>return total price</returns>
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.ShoppingCart.Price * e.Quantity);
        }

        /// <summary>
        /// The method clears linecollection
        /// </summary>  
        /// <returns></returns>
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }
}