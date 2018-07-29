using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.Grid
{
    public class GridPaginationModel : BaseGridModel
    {
        public GridPaginationModel(int numberOfItems, int selectedPage, string gridID, string refreshJavascriptFunctionName) : base(gridID, refreshJavascriptFunctionName)
        {
            this.Initialize();

            this.ItemsPerPage = this.ItemsPerPageList.First();

            this.CalculatePages(numberOfItems, selectedPage);
        }

        public GridPaginationModel(int numberOfItems, int selectedPage, int itemsPerPage, string gridID, string refreshJavascriptFunctionName) : base(gridID, refreshJavascriptFunctionName)
        {
            this.Initialize();

            this.ItemsPerPage = itemsPerPage == 0 ? this.ItemsPerPageList.First() : itemsPerPage;

            this.CalculatePages(numberOfItems, selectedPage);
        }

        public int SelectedPage { get; private set; }
        public int ItemsPerPage { get; private set; }
        public int NumberOfItems { get; private set; }
        public int NumberOfPages { get; private set; }
        public IEnumerable<int> ItemsPerPageList { get; private set; }


        private void Initialize()
        {
            this.ItemsPerPageList = new List<int>() { 10, 20, 30 };
        }

        private void CalculatePages(int numberOfItems, int selectedPage)
        {
            this.NumberOfItems = numberOfItems;
            this.NumberOfPages = (int)Math.Ceiling(numberOfItems * 1.0 / this.ItemsPerPage);

            this.SelectedPage = this.NumberOfPages != 0 && this.NumberOfPages < selectedPage ? this.NumberOfPages : selectedPage;
        }

        public string GetSelectedPageRange()
        {
            int leftRangeSide = ((this.SelectedPage - 1) * this.ItemsPerPage) + 1;
            int rightRangeSide = this.SelectedPage == this.NumberOfPages ? this.NumberOfItems : this.SelectedPage * this.ItemsPerPage;

            return leftRangeSide + " - " + rightRangeSide;
        }
    }
}