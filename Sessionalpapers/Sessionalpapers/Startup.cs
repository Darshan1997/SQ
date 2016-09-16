using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sessionalpapers.Startup))]
namespace Sessionalpapers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
