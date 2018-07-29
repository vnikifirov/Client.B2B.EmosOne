using Emos2.MVC.Models.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Emos2.MVC.Models.Filter
{
    public class FilterIntModel : FilterBaseModel
    {
        private List<SelectListItem> _filterValues;

        public FilterIntModel(string columnName, string gridID, string refreshJavascriptFuctionName) :
            base("../Filter/FilterInt", columnName, gridID, refreshJavascriptFuctionName, typeof(int?), new FilterPropertyModel())
        {
            this.Initialize();
        }

        public FilterIntModel(string columnName, string gridID, string refreshJavascriptFuctionName, FilterPropertyModel propertyState) :
            base("../Filter/FilterInt", columnName, gridID, refreshJavascriptFuctionName, typeof(int?), propertyState)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            SetPropertyValue();
            SetFilterValues();
        }

        private void SetPropertyValue()
        {
            var propertyValue = PropertyState.PropertyValue as string;

            if (string.IsNullOrEmpty(propertyValue))
            {
                PropertyState.PropertyValue = null;
            }
            else
            {
                int test;
                int.TryParse(propertyValue, out test);
                PropertyState.PropertyValue = test != 0 ? test : (int?)null;
            }
        }

        private void SetFilterValues()
        {
            _filterValues = new List<SelectListItem>();

            _filterValues.Add(new SelectListItem()
            {
                Value = FilterValue.Undefined.ToString(),
                Text = string.Empty,
                Selected = this.PropertyState.FilterValue == FilterValue.Undefined
            });

            _filterValues.Add(new SelectListItem()
            {
                Value = FilterValue.IsEqualTo.ToString(),
                Text = "Is Equal To",
                Selected = this.PropertyState.FilterValue == FilterValue.IsEqualTo
            });
        }

        public IEnumerable<SelectListItem> FilterValues => this._filterValues;

        public int? PropertyValue => PropertyState.PropertyValue as int?;
    }
}