using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityCode.Startup))]
namespace SecurityCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
