using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStarter.Startup))]
namespace MVCStarter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
