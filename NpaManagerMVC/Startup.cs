using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NpaManagerMVC.Startup))]
namespace NpaManagerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
