using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Emos2.MVC.Models.Filter
{
    public class FilterStringModel : FilterBaseModel
    {

        public FilterStringModel(string columnName, string gridID, string refreshJavascriptFuctionName) : 
            base("../Filter/FilterString", columnName, gridID, refreshJavascriptFuctionName, typeof(String), new FilterPropertyModel())
        {
            this.Initialize();
        }

        public FilterStringModel(string columnName, string gridID, string refreshJavascriptFuctionName, FilterPropertyModel propertyState) :
            base("../Filter/FilterString", columnName, gridID, refreshJavascriptFuctionName, typeof(string), propertyState)
        {
            this.Initialize();
        }

        public IEnumerable<SelectListItem> FilterValues { get; private set; }
        public string PropertyValue
        {
            get
            {
                return this.PropertyState.PropertyValue != null ? this.PropertyState.PropertyValue.ToString() : string.Empty;
            }
        }


        private void Initialize()
        {
            List<SelectListItem> filterValues = new List<SelectListItem>();

            filterValues.Add(new SelectListItem()
            {
                Value = FilterValue.Undefined.ToString(),
                Text = string.Empty,
                Selected = this.PropertyState.FilterValue == FilterValue.Undefined
            });

            filterValues.Add(new SelectListItem()
            {
                Value = FilterValue.IsEqualTo.ToString(),
                Text = "Is Equal To",
                Selected = this.PropertyState.FilterValue == FilterValue.IsEqualTo
            });

            filterValues.Add(new SelectListItem()
            {
                Value = FilterValue.Contains.ToString(),
                Text = "Contains",
                Selected = this.PropertyState.FilterValue == FilterValue.Contains
            });

            this.FilterValues = filterValues;
        }

    }
}