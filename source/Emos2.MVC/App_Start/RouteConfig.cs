using Emos2.MVC.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Emos2.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
   
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = RouteConstants.START_CONTROLLER, action = RouteConstants.START_ACTION, id = UrlParameter.Optional }
            );
        }
    }
}
