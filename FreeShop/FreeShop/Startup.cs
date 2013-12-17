using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeShop.Startup))]
namespace FreeShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
