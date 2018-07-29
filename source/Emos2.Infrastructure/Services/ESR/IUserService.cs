using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface IUserService : IServiceBaseESR<CEMUser>
    {
        void Create(UserCreateData userCreateData);
        void Update(UserUpdateData userUpdateData);
        CEMUser Select(string username);
    }
}
