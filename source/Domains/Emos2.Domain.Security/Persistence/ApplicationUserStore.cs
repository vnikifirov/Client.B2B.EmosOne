using Emos2.Infrastructure.Entities.Database;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Domain.Security.Persistence
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(IdentityDbContext<ApplicationUser> userDbContext) : base(userDbContext)
        { }
    }
}
