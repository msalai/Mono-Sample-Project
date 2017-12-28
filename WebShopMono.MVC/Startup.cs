using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShopMono.MVC.Startup))]
namespace WebShopMono.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
