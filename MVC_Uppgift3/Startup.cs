using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Uppgift3.Startup))]
namespace MVC_Uppgift3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
