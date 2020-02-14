using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bethanyspieshop.Models;

namespace bethanyspieshop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public pie Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
