using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Entities
{
    public class TokenData
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ClientId { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
        public string Error { get; set; }
        public int ExpiresInSeconds { get; set; }
        public bool IsValidUser { get; set; }
        public string TokenType { get; set; }
    }
}
