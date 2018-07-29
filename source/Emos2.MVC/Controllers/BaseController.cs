using Emos2.Infrastructure.Entities;
using Emos2.MVC.Helpers;
using Emos2.MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Emos2.MVC.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

        public BaseController()
        {


        }

        protected string GetUserAccessToken()
        {
            string accessToken = string.Empty;
            IPrincipal user = System.Web.HttpContext.Current.User;

            ClaimsIdentity userIdentity = user.Identity as ClaimsIdentity;
            if (userIdentity != null)
            {
                if (userIdentity.Claims.Any(c => c.Type.Equals(CustomClaimTypes.AccessToken)))
                {
                    Claim accessTokenClaim = userIdentity.Claims.FirstOrDefault(c => c.Type.Equals(CustomClaimTypes.AccessToken));

                    if (accessTokenClaim != null)
                    {
                        accessToken = accessTokenClaim.Value;
                    }
                }

            }
            return accessToken;
        }

        //protected ActionResult RedirectToLocal(string returnUrl)
        //{

        //    if (Url != null && Url.IsLocalUrl(returnUrl) && returnUrl.StartsWith("/"))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    return Redirect("/");
        //}


        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            string controller = requestContext.RouteData.Values["controller"].ToString();
            string action = requestContext.RouteData.Values["action"].ToString();

            if (controller == "Account")
            {
                return;
            }

            //Start: Check if token needs to be refreshed
            string accessToken = this.GetUserAccessToken();

            if (!string.IsNullOrEmpty(accessToken))
            {


                //if (RoleNames.RoleNamesDictionary == null || !RoleNames.RoleNamesDictionary.Any())
                //{

                //    APIRequest roleRequest = new APIRequest("roles/getall");
                //    roleRequest.Get();

                //    List<AppRoleModel> roles = JsonConvert.DeserializeObject<List<AppRoleModel>>(roleRequest.responseModel.Data);

                //    RoleNames.InitRoleNames(roles.ToDictionary(x => x.Id, x => x.Name));
                //}
            }
        }

     


    }
}