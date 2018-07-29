using Autofac;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.DatabaseEmos1;
using Emos2.Infrastructure.Services;
using Emos2.Infrastructure.Repositories;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Domain.Security.ServiceProviders
{
    public class TokenAuthenticationServiceProvider : OAuthAuthorizationServerProvider
    {
        private readonly IRepositoryESR<CEMUser> userRepository;
        private readonly IClientService emos1ClientService;

        public TokenAuthenticationServiceProvider(IContainer container)
        {
            this.userRepository = container.Resolve<IRepositoryESR<CEMUser>>();
            this.emos1ClientService = container.Resolve<IClientService>();
        }

         

        #region Overriden methods

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string clientId = string.Empty;
            string clientSecret = string.Empty;

            // Extract clientId and clientSecret
            if (!context.TryGetBasicCredentials(out clientId, out clientSecret))
            {
                context.TryGetFormCredentials(out clientId, out clientSecret);
            }

            // Checking if clientId has been sent in the request
            if (string.IsNullOrWhiteSpace(context.ClientId))
            {
                context.SetError("invalid_clientId", "ClientCode should be sent.");

                return Task.FromResult(0);
            }

            // Retrieving ApplicationClient
            //ApplicationClient applicationClient = this.applicationClientRepository.SelectBy(ac => ac.ApplicationId == clientId).FirstOrDefault();
            //if (applicationClient == null)
            //{
            //    context.SetError("invalid_clientId", $"Client '{context.ClientId}' is not registered in the system.");

            //    return Task.FromResult(0);
            //}

            //if (!applicationClient.IsActive)
            //{
            //    context.SetError("invalid_clientId", "Client is inactive.");
            //}

            // NOTE: Example of checking the ClientSecret
            //if (applicationClient.ApplicationType == ApplicationType.Angural)
            //{
            //    if (string.IsNullOrWhiteSpace(clientSecret))
            //    {
            //        context.SetError("invalid_clientId", "Client secret should be sent.");

            //        return Task.FromResult(0);
            //    }
            //    else if (applicationClient.Secret != TimeSheetUtil.Hash(clientSecret))
            //    {
            //        context.SetError("invalid_clientId", "Client secred is not valid.");

            //        return Task.FromResult(0);
            //    }
            //}

            //   context.OwinContext.Set<string>("refreshTokenLifeTimeInMinutes", applicationClient.RefreshTokenLifeTimeInMinutes.ToString());

            context.Validated();

            return Task.FromResult(0);
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            string connectionString = emos1ClientService.GetConnectionString(context.ClientId);
            userRepository.GetContext().SetConnectionString(connectionString);

            CEMUser user = userRepository.SelectBy(x => x.UserName == context.UserName && x.Password == context.Password).FirstOrDefault();


            //   ApplicationSignInManager signInManager = this.GetApplicationSignInManager(context.OwinContext);
            // ApplicationUser user = signInManager.UserManager.FindAsync(context.UserName, context.Password).Result;

            if (user != null)
            {
                // ClaimsIdentity userIdentity = signInManager.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ExternalBearer).Result;
                ClaimsIdentity userIdentity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.UserName), }, "OWINAuthenticationTypes", ClaimTypes.Name, ClaimTypes.Role);

                userIdentity.AddClaim(new Claim(ClaimTypes.Role, "guest"));
                userIdentity.AddClaim(new Claim(ClaimTypes.GivenName, $"{user.FirstName} {user.LastName}"));
                userIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.UserName));
                userIdentity.AddClaim(new Claim(ClaimTypes.Sid, user.ID.ToString())); //OK to store userID here?
                userIdentity.AddClaim(new Claim("FullName", $"{user.FirstName} {user.LastName}"));


                AuthenticationProperties authenticationProperties = new AuthenticationProperties(new Dictionary<string, string>
                {
                    {
                        "client_id", context.ClientId
                    }
                });

                AuthenticationTicket authenticationTicket = new AuthenticationTicket(userIdentity, authenticationProperties);

                context.Validated(authenticationTicket);

                // Setting LastLoginDate
                // user.LastLoginDate = DateTime.UtcNow;
                //signInManager.UserManager.Update(user);
            }
            else
            {
                context.SetError("invalid_grant", "The username or password is incorect");
            }

            return Task.FromResult(0);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (var property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult(0);
        }

        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            string originalClientId = context.Ticket.Properties.Dictionary["client_id"];
            string currentClientId = context.ClientId;

            if (originalClientId != currentClientId)
            {
                context.SetError("invalid_clientId", "Refresh Token is issued to a different clientId.");

                return Task.FromResult(0);
            }

            context.Validated(context.Ticket);

            return Task.FromResult(0);
        }

        #endregion
    }
}
