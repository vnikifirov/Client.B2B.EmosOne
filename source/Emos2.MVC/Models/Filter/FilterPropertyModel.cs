using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Filter
{
    public class FilterPropertyModel
    {
        public FilterValue FilterValue { get; set; }
        public string PropertyName { get; set; }
        public object PropertyValue { get; set; }
    }
}