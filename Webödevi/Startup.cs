using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webödevi.Startup))]
namespace Webödevi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
