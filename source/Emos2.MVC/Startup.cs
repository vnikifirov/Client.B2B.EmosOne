using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emos2.MVC.Startup))]
namespace Emos2.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
