using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Models.Users.Login
{
    public class LoginRefreshModel
    {
        public string RefresToken { get; set; }
        public string ClientId { get; set; }
    }
}