using Autofac;
using Emos2.Domain.Security.ServiceProviders;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Domain.Security.Configurations
{
    public static class AuthenticationConfig
    {
        //public static CookieAuthenticationOptions GetCookieAuthenticationOptions()
        //{
        //    CookieAuthenticationOptions cookieOptions = new CookieAuthenticationOptions
        //    {
        //        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        //        LoginPath = new PathString(ConfigurationManager.AppSettings["LoginPageUrlPath"]),
        //        Provider = new CookieAuthenticationProvider(),
        //        CookieName = "TimeSheetCookie",
        //        CookieHttpOnly = true,
        //        ExpireTimeSpan = TimeSpan.FromHours(1),
        //        SlidingExpiration = true
        //    };

        //    return cookieOptions;
        //}

        public static OAuthAuthorizationServerOptions GetTokenAuthenticationOptions(IContainer container)
        {
            OAuthAuthorizationServerOptions tokenOptions = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString(ConfigurationManager.AppSettings["TokenUrlPath"]),
                Provider = new TokenAuthenticationServiceProvider(container),
                RefreshTokenProvider = new RefreshTokenProvider(container),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(int.Parse(ConfigurationManager.AppSettings["AccessTokenExpireInMinutes"])),
                AllowInsecureHttp = true
            };

            return tokenOptions;
        }
    }
}
