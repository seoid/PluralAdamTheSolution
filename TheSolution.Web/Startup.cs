using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheSolution.Web.Startup))]
namespace TheSolution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
