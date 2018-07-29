using System.Collections.Generic;
using System.Web.Mvc;

namespace Emos2.MVC.Models.Shared
{
    public class CheckBoxListModel
    {
        public List<SelectListItem> Items { get; set; }
        public string SelectedItems { get; set; }
    }
}