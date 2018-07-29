using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace Emos2.MVC.Helpers
{
    public static class IdentityExtensions
    {
        public static string GetUserFullName(this IIdentity identity)
        {
            return identity.GetClaimValue("FullName");
        }

        public static string GetUserPhoto(this IIdentity identity)
        {
            return identity.GetClaimValue("PhotoImage");
        }

        public static string GetUserEmail(this IIdentity identity)
        {
            return identity.GetClaimValue("Email");
        }

        public static List<string> Roles(this IIdentity identity)
        {
            return ((ClaimsIdentity)identity).Claims
                           .Where(c => c.Type == ClaimTypes.Role)
                           .Select(c => c.Value)
                           .ToList();
        }

        private static string GetClaimValue(this IIdentity identity, string sClaim)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst(sClaim);
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}