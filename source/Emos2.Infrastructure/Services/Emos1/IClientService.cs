using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.DatabaseEmos1;
using Emos2.Infrastructure.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface IClientService : IServiceBaseEmos1<Client>
    {
        string GetConnectionString(string clientCode);
    }
}
