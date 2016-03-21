using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TunisiaMall.Startup))]
namespace TunisiaMall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
