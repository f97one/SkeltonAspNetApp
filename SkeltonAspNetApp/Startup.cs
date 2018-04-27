using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkeltonAspNetApp.Startup))]
namespace SkeltonAspNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
