using Emos2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Emos2.API.Attributes
{
    public class ValidateModelStateFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                string validationMessage = actionContext.ModelState.Values.SelectMany(v => v.Errors)
                                                                          .Select(e => e.ErrorMessage)
                                                                          .Aggregate((e1, e2) => $"{e1}{Environment.NewLine}{e2}");

                ErrorModel errorModel = new ErrorModel
                {
                    Title = "Validation failed",
                    Description = validationMessage
                };

                actionContext.Response = actionContext.Request.CreateResponse((HttpStatusCode)422, errorModel);
            }
        }
    }
}