using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Helpers
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger)); // System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Debug(string message)
        {
            message = message.Replace('\n', '_').Replace('\r', '_');
            log.Debug(message);
        }

        public static void Error(string message)
        {
            message = message.Replace('\n', '_').Replace('\r', '_');
            log.Error(message);
        }

        public static void Fatal(string message)
        {
            message = message.Replace('\n', '_').Replace('\r', '_');
            log.Fatal(message);
        }

        public static void Info(string message)
        {
            message = message.Replace('\n', '_').Replace('\r', '_');
            log.Info(message);
        }

        public static void Warn(string message)
        {
            message = message.Replace('\n', '_').Replace('\r', '_');
            log.Warn(message);
        }
    }
}