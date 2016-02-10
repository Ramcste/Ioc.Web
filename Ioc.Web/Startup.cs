using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ioc.Web.Startup))]
namespace Ioc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
