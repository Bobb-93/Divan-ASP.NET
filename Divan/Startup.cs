using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Divan.Startup))]
namespace Divan
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
