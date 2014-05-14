using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FooterBottom.Startup))]
namespace FooterBottom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
