using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projektarbete_MVC.Startup))]
namespace Projektarbete_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
