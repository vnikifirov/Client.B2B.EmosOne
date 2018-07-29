using Emos2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Emos2.API.Attributes
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception != null)
            {
                ErrorModel errorModel = new ErrorModel
                {
                    Title = "Execution failed",
                    Description = actionExecutedContext.Exception.Message
                };

                actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, errorModel);
            }
        }
    }
}