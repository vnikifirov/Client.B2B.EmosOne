using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface ILoginService
    {
        TokenData LogIn(string tokenServiceUrl, string username, string password, string clientCode);
        TokenData LogInRefresh(string tokenServiceUrl, string refreshToken, string clientid);
    }
}
