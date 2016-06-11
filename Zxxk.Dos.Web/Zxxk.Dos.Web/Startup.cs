using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zxxk.Dos.Web.Startup))]
namespace Zxxk.Dos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
