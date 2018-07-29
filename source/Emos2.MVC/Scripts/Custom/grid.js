function setGridPage(gridID, gridRefreshFunctionName, selectedPage, parentEntityId = null) {
    
    // Checking is the passed selectedPage already set
    if (selectedPage == getGridSelectedPage(gridID)) return;

    // Setting selected page
    var paginationElements = $('#' + gridID).find('a.pagination-number');

    for (var i = 0; i < paginationElements.length; i++) {

        var paginationElement = paginationElements[i];
        var pageNumber = $(paginationElement).find('span').html();

        if (pageNumber == selectedPage) {

            $(paginationElement).addClass('active');
        }
        else {

            $(paginationElement).removeClass('active');
        }
    }

    if (parentEntityId == null) {
        window[gridRefreshFunctionName]();
    }
    else
    {
        // Calling the gird refresh function
        window[gridRefreshFunctionName](parentEntityId);
    }
   
    
}

function getGridSelectedPage(gridID) {
    
    var paginationElement = $('#' + gridID).find('a.pagination-number.active');    
    var selectedPage = $(paginationElement).find('span').html();

    if (selectedPage == null || selectedPage == undefined) return 1;

    return selectedPage;
}

function getGridSelectedItemsPerPage(gridID) {

    return $('#btnItemsPerPage' + gridID).html();
}

function getGridState(gridID) {

    var gridState = {};

    gridState.SelectedPage = getGridSelectedPage(gridID);
    gridState.ItemsPerPage = getGridSelectedItemsPerPage(gridID);
    gridState.FilterState = getFilterState(gridID);

    return gridState;
}

function setNextPage(gridID, gridRefreshFunctionName, numberOfPages) {

    var currentSelectedPage = getGridSelectedPage(gridID);

    if (currentSelectedPage >= numberOfPages) return;

    currentSelectedPage++;

    setGridPage(gridID, gridRefreshFunctionName, currentSelectedPage);
}

function setPreviousPage(gridID, gridRefreshFunctionName) {

    var currentSelectedPage = getGridSelectedPage(gridID);

    if (currentSelectedPage <= 1) return;

    currentSelectedPage--;

    setGridPage(gridID, gridRefreshFunctionName, currentSelectedPage);
}

function setGridPageOnEnterPressed(e, gridID, gridRefreshFunctionName) {

    // Page will be set only if Enter is pressed
    if (e.keyCode != 13) return;

    var currentSelectedPage = getGridSelectedPage(gridID);
    var pageNumberText = $(e.target).val();

    // If the entered value is Not A Number, then return
    if (isNaN(pageNumberText)) {        

        $(e.target).val(currentSelectedPage);

        return;
    }

    var selectedPage = parseInt(pageNumberText);

    // Checking if entered page is in the page range
    var minPage = $(e.target).attr('min');
    var maxPage = $(e.target).attr('max');

    if (minPage <= selectedPage && maxPage >= selectedPage) {

        // Setting the entered page number
        setGridPage(gridID, gridRefreshFunctionName, selectedPage);
    }
    else {

        // Reseting the entered page number
        $(e.target).val(currentSelectedPage);
    }    
}

function resetPageNumberTextBox(e, gridID) {

    var currentPageNumber = getGridSelectedPage(gridID);
    var enteredPageValue = $(e.target).val();

    if (currentPageNumber != enteredPageValue) $(e.target).val(currentPageNumber);
}

function setItemsPerPage(itemsPerPage, gridID, gridRefreshFunctionName) {

    $('#btnItemsPerPage' + gridID).html(itemsPerPage);
    
    refreshGrid(gridRefreshFunctionName);
}

function refreshGrid(gridRefreshFunctionName,parentEntityId = null) {

    if (parentEntityId == null) {
        window[gridRefreshFunctionName]();
    }
    else
    {
        window[gridRefreshFunctionName](parentEntityId)
    }
    
}