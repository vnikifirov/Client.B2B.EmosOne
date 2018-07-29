using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Models.Users
{
    public class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}