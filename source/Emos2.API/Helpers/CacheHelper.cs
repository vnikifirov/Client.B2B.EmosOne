using Autofac;
using Emos2.Factory;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Helpers
{
    public class CacheHelper
    {

        public static string GetConnectionString(string clientCode)
        {
            string sKey = $"{clientCode}ClientConnectionString";
            string connectionString = string.Empty; 

            if (HttpRuntime.Cache[sKey]!=null)
            {
                connectionString = HttpRuntime.Cache[sKey].ToString();
            }

            if (string.IsNullOrEmpty(connectionString))
            {
                Autofac.IContainer container = ServiceFactoryBuilder.container;
                IClientService emos1ClientService = container.Resolve<IClientService>();

                connectionString = emos1ClientService.GetConnectionString(clientCode);

                // not using cache during testing
                if (!string.IsNullOrEmpty(connectionString))
                {
                    HttpRuntime.Cache.Insert(sKey, connectionString, null, DateTime.UtcNow.AddHours(10), System.Web.Caching.Cache.NoSlidingExpiration);
                }
                else
                {
                    throw new Exception($"No connection string for {clientCode}!");
                }
            }

            return connectionString;
        }


        public static IEnumerable<int> GetUserPermitedActions(int userId, string clientCode)
        {
            string sKey = "userPermitedActions";
            IEnumerable<int> userPermitedActions = (IEnumerable<int>)HttpRuntime.Cache[sKey];

            if (userPermitedActions == null || userPermitedActions.Count() == 0)
            {
                Autofac.IContainer container = ServiceFactoryBuilder.container;
                IUserPermissionService userProfileService = container.Resolve<IUserPermissionService>();

                userProfileService.SetClientConnectionString(GetConnectionString(clientCode ));
                userPermitedActions = userProfileService.GetAllPermitedActions(userId);
                

                // not using cache during testing
                //if (userPermitedActions != null && userPermitedActions.Count>0)
                //{
                //    HttpRuntime.Cache.Insert(sKey, userPermitedActions, null, DateTime.UtcNow.AddHours(10), System.Web.Caching.Cache.NoSlidingExpiration);
                //}
            }

            return userPermitedActions;
        }

    }
}