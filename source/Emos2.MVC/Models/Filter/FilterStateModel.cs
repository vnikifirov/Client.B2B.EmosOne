using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Filter
{
    public class FilterStateModel
    {

        public string SortingColumn { get; set; }
        public SortingDirection SortingDirection { get; set; }
        public Type SortingPropertyType { get; set; }
        public IEnumerable<FilterPropertyModel> Filters { get; set; }


    }

    public enum SortingDirection
    {
        Undefined = 0,
        Ascending = 1,
        Descending = 2
    }

    public enum FilterValue
    {
        Undefined = 0,
        IsEqualTo = 1,
        Contains = 2
    }
}