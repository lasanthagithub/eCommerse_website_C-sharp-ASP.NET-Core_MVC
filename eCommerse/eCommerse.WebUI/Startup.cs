using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerse.WebUI.Startup))]
namespace eCommerse.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
