using System;

namespace Projektarbete_MVC.Cart.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }
    }
}