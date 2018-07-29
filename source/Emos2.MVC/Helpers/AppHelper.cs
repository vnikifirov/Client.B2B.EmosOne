using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Helpers
{
    public static class AppHelper
    {
        public static string ClientCode()
        {
            var url = HttpContext.Current.Request.Url.Authority;

            return url.Substring(0, url.IndexOf("."));
        }
    }
}