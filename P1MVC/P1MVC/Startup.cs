using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P1MVC.Startup))]
namespace P1MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
