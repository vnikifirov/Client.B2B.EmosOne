function openFilter(openFilterButtonEvent, filterID) {
    var filter = $('#' + filterID);

    filter.toggleClass('active');

    // If filter is open, after applying the Toggle operation, click event is set on the document, 
    // so that when User clicks outside from the filter's DIV, 
    // filter will be closed and event will be erased from the DOM
    if (filter.hasClass('active')) {

        $(document).on('click.' + filterID, function (e) {

            if ($(openFilterButtonEvent.target).is(e.target)) return;

            if (!filter.is(e.target) && $(e.target).closest(filter).length == 0) {

                filter.removeClass('active');

                $(document).off('click.' + filterID);
            }
        });
    }
    else {

        $(document).off('click.' + filterID);
    }
}

function setSortingOrder(filterID, gridID, columnName, sortingOrder, gridRefreshFunctionName) {
    $('#' + gridID).attr('sorting-order', sortingOrder);
    $('#' + gridID).attr('sorting-column-name', columnName);

    $('#' + filterID).removeClass('active');
    $(document).off('click.' + filterID);

   
    var parentEntityId = ($('#' + gridID)) ? $('#' + gridID).attr("parententity") : null;
    refreshGrid(gridRefreshFunctionName, parentEntityId);
}

function getFilterState(gridID) {
    var filterState = {};

    filterState.SortingColumn = $('#' + gridID).attr('sorting-column-name');
    filterState.SortingDirection = $('#' + gridID).attr('sorting-order');
    filterState.SortingPropertyType = $('#' + gridID).attr('filter-type');
    filterState.isValid = true;

    var filters = [];
    var filterControls = $('#' + gridID).find('.filter-container');

    for (var i = 0; i < filterControls.length; i++) {

        var filterControl = filterControls[i];

        var columnName = $(filterControl).attr('column-name');
        var propertyValue = null;
        var filterValue = null;

        var inputElement = $(filterControl).find('input');

        if (inputElement.length != 0) //input element exists - filter by the entered property value and the chosen filter type
        {
            var liSelect = $(filterControl).find('li.list-select');
            var dropDownElement = $(liSelect).find('select');

            propertyValue = $(inputElement).val();
            filterValue = $(dropDownElement).val();

            if (propertyValue && filterValue === 'Undefined') { //the property value has been set but the filter type has not been chosen
                if (dropDownElement[0].length === 2) {//if there is only one filter type ('Undefined' does not count)
                    dropDownElement[0].selectedIndex = 1; //select it as the default filter type and do filtering
                    filterValue = $(dropDownElement).val();
                } else { //warn user that they must choose a filter type to continue
                    openModalWindow('Invalid Filter', 'Please choose a filter type to get a proper result.', function () { $(inputElement).val(null); });
                    filterState.isValid = false;
                    break;
                }
            }
        }
        else if (inputElement.length == 0 && $(filterControl).find('li.list-select').length != 0) { //input element does not exist - filter by the chosen lookup value on the dropdown list
            var liSelect = $(filterControl).find('li.list-select');
            var dropDownElement = $(liSelect).find('select');

            propertyValue = $(dropDownElement).val();

            //if (propertyValue == 0) propertyValue = null;

            filterValue = 1;
        }

        var filter = {};
        filter.FilterValue = filterValue;
        filter.PropertyName = columnName;
        filter.PropertyValue = propertyValue;

        filters.push(filter);
    }

    filterState.Filters = filters;

    return filterState;
}

function filterGrid(gridRefreshFunctionName) {

    refreshGrid(gridRefreshFunctionName);
}

function clearFilter(filterID, gridID, columnName, gridRefreshFunctionName) {

    var filterControl = $('#' + filterID);
    var sortingColumnName = $('#' + gridID).attr('sorting-column-name');

    if (sortingColumnName == columnName) $('#' + gridID).removeAttr('sorting-column-name');

    var inputElement = filterControl.find('input');

    if (inputElement.length != 0) {
        var liSelect = filterControl.find('li.list-select');
        var dropDownElement = $(liSelect).find('select');

        $(inputElement).val(null);
        $(dropDownElement).val(0);
    }
    else if (inputElement.length == 0 && filterControl.find('li.list-select').length != 0) {

        var liSelect = filterControl.find('li.list-select');
        var dropDownElement = $(liSelect).find('select');

        $(dropDownElement).val(undefined);
    }

    filterGrid(gridRefreshFunctionName);
}