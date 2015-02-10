using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class CartLine
    {
        public ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}