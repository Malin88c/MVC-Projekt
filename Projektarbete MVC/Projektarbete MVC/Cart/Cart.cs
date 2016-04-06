using System;
using System.Linq;
using Projektarbete_MVC.Cart.Models;

namespace Projektarbete_MVC.Cart
{
    public class Cart
    {
        public void AddCartItem(CartItem cartItem)
        {
            MvcApplication.CartObject.CartItems.Add(cartItem);
        }
        
        public CartItem GetItem(string name)
        {
            return MvcApplication.CartObject.CartItems.FirstOrDefault(x => x.Name == name);
        }

        public int GetTotalAmount()
        {
            return MvcApplication.CartObject.CartItems.Sum(x => x.Price);
        }

        public int GetTotalQuantity()
        {
            return MvcApplication.CartObject.CartItems.Sum(x => x.Quantity);
        }

        public void Delete(Guid id)
        {
            var cartItem = MvcApplication.CartObject.CartItems.FirstOrDefault(x => x.Id == id);

            if (cartItem != null)
            {
                MvcApplication.CartObject.CartItems.Remove(cartItem);
            }
        }
    }
}