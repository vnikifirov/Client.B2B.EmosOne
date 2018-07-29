using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Enums
{
    /// <summary>
    /// Type of applications that can acess to the API
    /// </summary>
    public enum ApplicationType
    {
        Undefined = 0,
        Postman = 1,
        Angural = 2,
        Android = 3,
        iOS = 4
    }

    public enum OrderByType
    {
        Undefined = 0,
        Ascending = 1,
        Descending = 2
    }

    public enum UserRoles
    {
        Undefined = 0,
        User = 1,
        Admin = 2
    }
}
