using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }

        public ShoppingCart()
        {

        }
        public ShoppingCart(string username)
        {
            this.UserName = username;
        }

        
    }
}
