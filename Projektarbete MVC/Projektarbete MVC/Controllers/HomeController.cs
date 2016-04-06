using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projektarbete_MVC.Cart.Models;
using Projektarbete_MVC.MockData;
using Projektarbete_MVC.Models;

namespace Projektarbete_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cats()
        {
            ViewBag.Message = "Här kan du bläddra bland de katter vi har att erbjuda.";

            var list = MvcApplication.ProductList;

            return View(list);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        public ActionResult Cart()
        {
            var cart = MvcApplication.CartObject;

            return View(cart);
        }

        [HttpPost]
        public ActionResult AddToCart(int id)
        {
            var cart = new Cart.Cart();

            var cat = MvcApplication.ProductList.FirstOrDefault(x => x.Id == id);

            if (cat == null)
            {
                return RedirectToAction("Cats");
            }

            var cartItem = cart.GetItem(cat.Name);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    Id = Guid.NewGuid(),
                    Name = cat.Name,
                    Price = cat.Price,
                    Quantity = 1
                };

                cart.AddCartItem(cartItem);
            }
            else
            {
                cartItem.Quantity += 1;
            }
            

            return RedirectToAction("Cats");
        }

        public ActionResult DeleteFromCart(Guid id)
        {
            var cart = new Cart.Cart();

            cart.Delete(id);

            return RedirectToAction("Cart");
        }
    }
}