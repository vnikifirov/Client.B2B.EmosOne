using Emos2.MVC.Models.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Grid
{
    public class GridStateModel
    {
        public int SelectedPage { get; set; }
        public int ItemsPerPage { get; set; }
        public FilterStateModel FilterState { get; set; }
    }
}