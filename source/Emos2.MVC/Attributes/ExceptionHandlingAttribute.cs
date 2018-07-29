
using Emos2.MVC.Helpers;
using Emos2.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Emos2.MVC.Attributes
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception != null)
            {
                Logger.Error("ERROR! Message=" + actionExecutedContext.Exception.Message + "\n\rSTACK TRACE=" + actionExecutedContext.Exception.StackTrace);
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