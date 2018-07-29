using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Filter
{
    public class FilterSortingModel : FilterBaseModel
    {

        public FilterSortingModel(string columnName, string gridID, string refreshJavascriptFuctionName, Type propertyType) : 
            base("../Filter/FilterSorting", columnName, gridID, refreshJavascriptFuctionName, propertyType)
        { }

    }
}