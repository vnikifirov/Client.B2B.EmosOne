using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup("WebApiOwinConfig", typeof(Emos2.API.App_Start.Startup))]
//[assembly: OwinStartup(typeof(Startup))]
namespace Emos2.API.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();

            WebApiConfig.Register(httpConfiguration, app);

            MapperConfig.InitializeMapper();
        }
    }
}