using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClienteWS.Startup))]
namespace ClienteWS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
