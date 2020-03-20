using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transcript_Repository.Startup))]
namespace Transcript_Repository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
