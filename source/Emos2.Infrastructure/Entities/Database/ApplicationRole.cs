using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Entities.Database
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
