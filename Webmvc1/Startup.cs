using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webmvc1.Startup))]
namespace Webmvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
