using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerPortal.UI.Startup))]
namespace CustomerPortal.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
