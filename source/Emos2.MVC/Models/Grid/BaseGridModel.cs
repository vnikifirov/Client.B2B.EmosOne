using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Grid
{
    public class BaseGridModel
    {
        public BaseGridModel(string gridID, string refreshJavascriptFuctionName)
        {
            this.GridID = gridID;
            this.RefreshJavascriptFuctionName = refreshJavascriptFuctionName;
        }

        public string RefreshJavascriptFuctionName { get; private set; }
        public string GridID { get; private set; }
    }
}