using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRS.Web.Startup))]
namespace TRS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
