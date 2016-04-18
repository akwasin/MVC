using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Uppgift5.Startup))]
namespace MVC_Uppgift5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
