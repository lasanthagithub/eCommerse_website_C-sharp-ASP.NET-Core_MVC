using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerse.WebUi.Startup))]
namespace eCommerse.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
