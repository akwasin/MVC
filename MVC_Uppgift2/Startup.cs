﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Uppgift2.Startup))]
namespace MVC_Uppgift2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
