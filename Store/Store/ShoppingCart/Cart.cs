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

    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

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

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.ShoppingCart.Price * e.Quantity);
        }

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