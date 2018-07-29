using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Attributes
{
    public class RolesAttribute : Attribute
    {
        public string[] Roles { get; set; }
    }
}