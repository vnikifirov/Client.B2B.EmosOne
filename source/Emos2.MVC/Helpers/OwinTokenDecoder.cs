using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Helpers
{
    public class OwinTokenDecoder
    {
        private string token;

        public OwinTokenDecoder(string token)
        {
            this.token = token;
        }

        public AuthenticationTicket Decode()
        {
            TicketDataFormat ticketDataFormat = new TicketDataFormat(new MachineDataProtector());

            return ticketDataFormat.Unprotect(this.token);
        }
    }

    class MachineDataProtector : IDataProtector
    {
        private readonly string[] purpose = { typeof(OAuthAuthorizationServerMiddleware).Namespace, "Access_Token", "v1" };

        public byte[] Protect(byte[] userData)
        {
            throw new NotImplementedException();
        }

        public byte[] Unprotect(byte[] protectedData)
        {
            return System.Web.Security.MachineKey.Unprotect(protectedData, this.purpose);
        }
    }



}