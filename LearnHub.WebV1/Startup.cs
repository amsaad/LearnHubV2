using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnHub.Web.Startup))]
namespace LearnHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
