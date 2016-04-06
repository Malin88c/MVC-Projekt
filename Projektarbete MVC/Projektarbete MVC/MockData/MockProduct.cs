using System.Collections.Generic;
using Projektarbete_MVC.Models;

namespace Projektarbete_MVC.MockData
{
    public static class MockProduct
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                GetProduct(1, "Maine Coon", "mainecoon.jpg", 4999, 2),
                GetProduct(2, "Norsk Skogskatt", "norskskogskatt.jpg", 2899, 2),
                GetProduct(3, "Bengal", "bengal.jpg", 8599, 2),
            };
        }

        private static Product GetProduct(int id, string name, string imageName, int price, int quantity)
        {
            return new Product
            {
                Id = id,
                ImageName = imageName,
                Name = name,
                Price = price,
                QuantityInStore = quantity
            };
        }
    }
}