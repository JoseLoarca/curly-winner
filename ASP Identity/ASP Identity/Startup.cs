using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Identity.Startup))]
namespace ASP_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
