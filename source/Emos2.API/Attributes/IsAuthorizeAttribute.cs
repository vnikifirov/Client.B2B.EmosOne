using Emos2.Infrastructure.Declares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Net;
using Emos2.API.Models;
using Emos2.API.Helpers;
using Microsoft.AspNet.Identity;

namespace Emos2.API.Attributes
{
    public class IsAuthorizeAttribute : AuthorizeAttribute
    {

        private IEnumerable<int> permissionsRequired { get; set; }


        public IsAuthorizeAttribute(params Permission[] permissionsRequired)
        {
            if (permissionsRequired.Any())
                this.permissionsRequired = permissionsRequired.Select(x => (int)x);
        }


        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            ErrorModel errorModel = new ErrorModel();

            if (actionContext.RequestContext.Principal.Identity.IsAuthenticated)
            {
                errorModel.Title = "Authorization failed";
                errorModel.Description = "This user is not authorized to consume this resource.";

                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, errorModel);
            }
            else
            {
                errorModel.Title = "Authentication failed";
                errorModel.Description = "This user has no valid credentials to consume this resource.";

                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden, errorModel);
            }
        }


        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
          //  string username = actionContext.RequestContext.Principal.Identity.Name;
          //  string userId = actionContext.RequestContext.Principal.Identity.GetUserId();
            int userId = actionContext.RequestContext.Principal.GetUserId();

            // get ClientCode
            string clientCode = string.Empty;
            if (System.Web.HttpContext.Current.Request.Headers != null)
            { 
                IEnumerable<string> headerValues = System.Web.HttpContext.Current.Request.Headers.GetValues("ClientCode");
                if (headerValues != null)
                {
                     clientCode = headerValues.FirstOrDefault();
                }
            }

            IEnumerable<int> userPermitedActions =  CacheHelper.GetUserPermitedActions(userId, clientCode); 

            return !permissionsRequired.Except(userPermitedActions).Any();
        }

    }
}