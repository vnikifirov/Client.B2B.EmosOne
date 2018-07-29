using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Filter
{
    public abstract class FilterBaseModel
    {
        public FilterBaseModel(string viewPath, string columnName, string gridID, string refreshJavascriptFuctionName, Type propertyType)
        {
            this.Initialize(viewPath, columnName, gridID, refreshJavascriptFuctionName, propertyType);

            this.PropertyState = new FilterPropertyModel();
        }

        public FilterBaseModel(string viewPath, string columnName, string gridID, string refreshJavascriptFuctionName, Type propertyType, FilterPropertyModel propertyState)
        {
            this.Initialize(viewPath, columnName, gridID, refreshJavascriptFuctionName, propertyType);

            this.PropertyState = propertyState;
        }


        public string ViewPath { get; private set; }
        public string ColumnName { get; private set; }
        public string FilterID { get; private set; }
        public string GridID { get; private set; }
        public string RefreshJavascriptFuctionName { get; private set; }
        public FilterPropertyModel PropertyState { get; private set; }
        public Type PropertyType { get; protected set; }


        private void Initialize(string viewPath, string columnName, string gridID, string refreshJavascriptFuctionName, Type propertyType)
        {
            this.ViewPath = viewPath;
            this.ColumnName = columnName;
            this.FilterID = $"string{gridID}{columnName}";
            this.GridID = gridID;
            this.RefreshJavascriptFuctionName = refreshJavascriptFuctionName;
            this.PropertyType = propertyType;
        }
    }
}