using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiHub.Startup))]
namespace GiHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
