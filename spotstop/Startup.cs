using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(spotstop.Startup))]
namespace spotstop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
