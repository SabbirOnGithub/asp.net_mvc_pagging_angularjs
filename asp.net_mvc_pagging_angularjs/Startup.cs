using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net_mvc_pagging_angularjs.Startup))]
namespace asp.net_mvc_pagging_angularjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
