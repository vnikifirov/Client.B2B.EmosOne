using Emos2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Emos2.API
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            if (context.Exception != null)
            {
                ErrorModel errorModel = new ErrorModel
                {
                    Title = "Execution failed",
                    Description = context.Exception.Message
                };

                context.ExceptionContext.Response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, errorModel);
            }
        }
    }
}