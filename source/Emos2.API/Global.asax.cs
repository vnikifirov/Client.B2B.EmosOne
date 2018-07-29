using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Emos2.API
{
    public class Emos2ApiApplication : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }
    }
}