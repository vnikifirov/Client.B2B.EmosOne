using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Services
{
    public class UserPermissionService : ServiceBaseESR<UserSystemAction>, IUserPermissionService
    {
        private IRepositoryESR<UserSystemAction> myRepository;

        public UserPermissionService(IRepositoryESR<UserSystemAction> userRepository) : base(userRepository)
        {
            this.myRepository = userRepository;
        }

        public IEnumerable<int> GetAllPermitedActions(int userId)
        {

            return myRepository.SelectBy(x => x.UserID== userId).Select(x => x.SystemActionID);
        }
    }
}
