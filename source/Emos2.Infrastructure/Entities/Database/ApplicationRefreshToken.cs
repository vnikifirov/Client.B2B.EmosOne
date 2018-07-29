using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Entities.Database
{
    public class ApplicationRefreshToken : IEntity
    {
        public int ID { get; set; }
        public string RefreshTokenId { get; set; }
        public string Username { get; set; }
        public string ApplicationClientId { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
        public string ProtectedTicket { get; set; }
    }
}
