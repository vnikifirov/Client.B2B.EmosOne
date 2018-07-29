using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Filter
{
    public class FilterModel
    {
        public FilterModel()
        {
            this.Filters = new Dictionary<string, FilterBaseModel>();
        }

        public Dictionary<string, FilterBaseModel> Filters { get; private set; }
    }
}