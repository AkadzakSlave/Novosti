using Models.Services;
using System.Collections.Generic;

namespace Models.Services
{
    public class CartService
    {
        private List<Cookie> cartItems = new List<Cookie>();

        public void AddToCart(Cookie product)
        {
            cartItems.Add(product);
            
        }
        public List<Cookie> GetCartItems()
        {
            return cartItems;
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
        public decimal GetTotalPrice()
        {
            decimal total =  cartItems.Sum(cookie => cookie.Price);
            return total;
        }
    }
}