using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSource.Startup))]
namespace WebSource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
