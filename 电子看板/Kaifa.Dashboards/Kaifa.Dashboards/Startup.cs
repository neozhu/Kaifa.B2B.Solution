using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kaifa.Dashboards.Startup))]
namespace Kaifa.Dashboards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
