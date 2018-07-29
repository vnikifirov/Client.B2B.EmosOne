using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Models.Users.Login
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClientCode { get; set; }
    }
}