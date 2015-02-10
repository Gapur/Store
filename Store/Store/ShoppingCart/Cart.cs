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

        public void AddItem(ShoppingCart cart, int quantity)
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
        }

        public void RemoveLine(System.Guid Id)
        {
            lineCollection.RemoveAll(l => l.ShoppingCart.Id == Id);
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