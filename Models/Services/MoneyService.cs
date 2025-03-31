using System.Linq;

namespace Models.Services
{
    public class MoneyService
    {
        public decimal TotalMany { get; set; } = 300m;
        public bool BuyAll(CartService cartService)
        {
            if (cartService.GetTotalPrice() <= TotalMany)
            {
                TotalMany -= cartService.GetTotalPrice();
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}