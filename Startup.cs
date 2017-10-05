using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MersatPOSApplication.Web.Startup))]
namespace MersatPOSApplication.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
