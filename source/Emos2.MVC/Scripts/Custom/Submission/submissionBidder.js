/*****************  bidders ************************/

function openBidder(bidderId, submissionId, typeId) {
    showLoader();
    $.ajax({
        method: "GET",
        url: "/Bidder/BidderCreate",
        data: { bidderId: bidderId, submissionId: submissionId, typeId: typeId },
        cache: false
    }).success(function (data) {

        $('#bidderCreateContent').html(data);
        $('#bidderCreateModal').modal('show');
        $('#bidderCreateModal').on('hidden.bs.modal', function () {
            $('#bidderCreateContent').html('');
        })

        setRegisteredOnClickEvent();
        if ($('#IsReadOnly').val() == 0) {
            initRichTextEditor('#bidderCreateContent textarea');
        }
        else {
            checkReadOnly('bidderCreateContent');
            $('#bidderCreateContent textarea').hide();
            $('#bidderCreateContent .disabled-panel').show();
            $('#btnBidderSave').hide();
            $('#btnBidderCancel').html("<span class=\"fa fa-close\"></span> Close")
        }
        
       
        

    }).always(function () {
        hideLoader();
    });

}

function setRegisteredOnClickEvent() {
    $('input[name="IsRegisteredHelper"]').on('click', function () {

        toggleCompanyID();
    });
    toggleCompanyID()
}

function toggleCompanyID() {
    
    if ($('#IsRegisteredHelper:checked').val() == 2) {
        $('#btnCompanyVerify').attr('disabled', 'disabled');
        $('#CompanyID').attr('disabled', 'disabled');
    }
    else {

        $('#btnCompanyVerify').removeAttr('disabled');
        $('#CompanyID').removeAttr('disabled');
    }
}

/*
function editBidder(bidderId, submissionId) {
    $.ajax({
        method: "GET",
        url: "/Bidder/SaveBidder",
        data: { bidderId: bidderId, submissionId: submissionId },
        cache: false
    }).success(function (data) {
        $('#bidderCreateContent').html(data);
        $('#bidderCreateModal').modal('show');
        $('#bidderCreateModal').on('hidden.bs.modal', function () {
            $('#bidderCreateContent').html('');
        })
        //initRichTextEditor('#SubmissionContractSaveContent textarea');
 

    }); 
}
*/


function deleteBidder(event, bidderId, submissionId, typeId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteBidderOkBtnClick);
    function _deleteBidderOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Bidder/BidderDelete",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { bidderId: bidderId, typeId: typeId },
            cache: false
        }).success(function (data) {
            refreshBidderGrids(submissionId, typeId);
            //Save submission to calculate new approval
            $('#submissionSaveForm').submit();
        });
    }
}

function bidderSaveSuccess(data) {
    showMessage(data);
    if (data.IsSuccess) {
        refreshBidderGrids(data.Model.SubmissionId, data.Model.TypeId);
        $('#bidderCreateModal').modal('hide');
        //Save submission to calculate new approval
        $('#submissionSaveForm').submit();
    }
}

function refreshBidderGrids(submissionId, realTypeId) {
    refreshBidderGrid(submissionId, realTypeId, realTypeId);
    switch (realTypeId) {
        case 10:
            refreshBidderGrid(submissionId, realTypeId, 30);
            refreshBidderGrid(submissionId, realTypeId, 40);
            break;
        case 20:
            break;
        case 30:
            refreshBidderGrid(submissionId, realTypeId, 10);
            break;
        case 40:
            refreshBidderGrid(submissionId, realTypeId, 10);
            break;

    }
}
function refreshBidderGrid(submissionId, realTypeId, renderTypeId) {

  
    $.ajax({
        method: "GET",
        url: "/Bidder/BidderGrid",
        data: { submissionId: submissionId, renderTypeId: renderTypeId, realTypeId: realTypeId },
        cache: false,
        async: false
    }).success(function (data) {

        switch (renderTypeId) {
            case 10:
                $('#bidderGridContainer').html(data);
                break;
            case 20:
                $('#additionalBidderGridContainer').html(data);
                break;
            case 30:
                $('#bidderGridContainerTechnical').html(data);
                break;
            case 40:
                $('#bidderGridContainerCommercial').html(data);
                break;
        }

        refreshBidderSummary();


    });

    
}

function refreshBidderSummary() {
    $('#bidderNoResponseCount').val($(".bidderNoResponse:checked").length)
    $('#bidderSubmittedCount').val($(".bidderSubmitted:checked").length)
    $('#bidderDeclinedCount').val($(".bidderDeclined:checked").length)

    $('#bidderAcceptableCount').val($(".bidderAcceptable:checked").length)
    $('#bidderNotAcceptableCount').val($(".bidderNotAcceptable:checked").length)

    $('#bidderCount').val($(".bidderSubmitted").length)
}

function refreshBiddersGrid() {

    var gridState = getGridState('biddersGrid');
    var submissionId = $('#SubmissionID').val();
    var submissionType = $('#TypeId').val();

    if (!submissionId){
        submissionId = $('#Id').val();
    }
    if (!submissionType) {
        submissionType = $('#SubmissionTypeID').val();
    }
    if (!submissionId) {
        submissionId = 0;
    }
    if (!gridState.FilterState.isValid) return false;

    //showLoader();
    $.ajax({
        method: "POST",
        url: "/Bidder/BiddersGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "submissionId": submissionId, "submissionType": submissionType }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#biddersGrid').html(data);
    }).always(function () {
        //hideLoader();
    });
}

function toggleCollapse(rowId) {
    $(rowId).collapse('toggle');
}
/******************************************************/
