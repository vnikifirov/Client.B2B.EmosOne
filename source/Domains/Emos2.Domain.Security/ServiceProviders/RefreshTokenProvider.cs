using Autofac;
using Emos2.Infrastructure;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Repositories;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Domain.Security.ServiceProviders
{
    public class RefreshTokenProvider : IAuthenticationTokenProvider
    {
        private readonly IRepositoryESR<ApplicationRefreshToken> refreshTokenRepository;

        public RefreshTokenProvider(IContainer container)
        {
            //this.refreshTokenRepository = container.Resolve<IRepositoryESR<ApplicationRefreshToken>>();
        }

        #region Private methods

        #endregion

        #region IAuthenticationTokenProvider implementations

        public void Create(AuthenticationTokenCreateContext context)
        { }

        public Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            string clientId = context.Ticket.Properties.Dictionary["client_id"];

            if (!string.IsNullOrWhiteSpace(clientId))
            {
                string refreshTokenId = Guid.NewGuid().ToString();
                string refreshTokenLifeTimeInMinutes = context.OwinContext.Get<string>("refreshTokenLifeTimeInMinutes");

                ApplicationRefreshToken newRefreshToken = new ApplicationRefreshToken
                {
                    RefreshTokenId = HashUtils.Hash(refreshTokenId),
                    Username = context.Ticket.Identity.Name,
                    ApplicationClientId = clientId,
                    Issued = DateTime.UtcNow,
                    Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(refreshTokenLifeTimeInMinutes))
                };

                context.Ticket.Properties.IssuedUtc = newRefreshToken.Issued;
                context.Ticket.Properties.ExpiresUtc = newRefreshToken.Expires;

                newRefreshToken.ProtectedTicket = context.SerializeTicket();

                //if (refreshTokenRepository.SelectAll().Any(rt => rt.Username == newRefreshToken.Username && rt.ApplicationClientId == newRefreshToken.ApplicationClientId))
                //{
                //    ApplicationRefreshToken oldRefreshToken = refreshTokenRepository.SelectBy(rt => rt.Username == newRefreshToken.Username && rt.ApplicationClientId == newRefreshToken.ApplicationClientId).First();
                //    refreshTokenRepository.Delete(oldRefreshToken);
                //}

                //refreshTokenRepository.Insert(newRefreshToken);
                //refreshTokenRepository.SaveChanges();

                context.SetToken(refreshTokenId);
            }

            return Task.FromResult(0);
        }

        public void Receive(AuthenticationTokenReceiveContext context)
        { }

        public Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {
            string hashedRefreshTokenId = HashUtils.Hash(context.Token);

            if (this.refreshTokenRepository.SelectAll().Any(rt => rt.RefreshTokenId == hashedRefreshTokenId))
            {
                ApplicationRefreshToken refreshToken = this.refreshTokenRepository.SelectBy(rt => rt.RefreshTokenId == hashedRefreshTokenId).First();

                context.DeserializeTicket(refreshToken.ProtectedTicket);
                this.refreshTokenRepository.Delete(refreshToken);
                this.refreshTokenRepository.SaveChanges();
            }

            return Task.FromResult(0);
        }

        #endregion
    }
}
