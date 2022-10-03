using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kalkulator.Startup))]
namespace Kalkulator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
