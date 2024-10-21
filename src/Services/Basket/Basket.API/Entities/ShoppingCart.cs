using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public decimal TotalPrice
        {
            get 
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }
        }

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            Username = userName;
            Items = new List<ShoppingCartItem>();
        }        
    }    
}
