using System.Collections.Generic;
using System.Linq;

namespace Projektarbete_MVC.Cart.Models
{
    public class CartObject
    {
        public List<CartItem> CartItems { get; set; }

        public int TotalAmount {
            get { return CartItems.Sum(x => x.Price * x.Quantity); }}

        public int TotalQuantity
        {
            get { return CartItems.Sum(x => x.Quantity); }
        }
    }
}