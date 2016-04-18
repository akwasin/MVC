using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Uppgift4.Startup))]
namespace MVC_Uppgift4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
