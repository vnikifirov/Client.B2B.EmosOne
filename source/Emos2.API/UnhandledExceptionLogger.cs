using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Emos2.API
{
    public class UnhandledExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            // NOTE: Use ILogService to log error when it is implemented
            base.Log(context);
        }
    }
}