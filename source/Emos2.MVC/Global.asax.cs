using Emos2.MVC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Emos2.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Name;
        }


        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Logger.Error(exception.ToString());
        }


    }
}
