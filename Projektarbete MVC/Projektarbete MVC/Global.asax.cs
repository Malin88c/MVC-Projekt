using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Projektarbete_MVC.Cart.Models;
using Projektarbete_MVC.MockData;
using Projektarbete_MVC.Models;

namespace Projektarbete_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IEnumerable<Product> ProductList;

        public static Cart.Models.CartObject CartObject;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ProductList = MockProduct.GetProducts();
            CartObject = new CartObject
            {
                CartItems = new List<CartItem>()
            };
        }
    }
}
