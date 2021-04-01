using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadatak3.Startup))]
namespace Zadatak3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
