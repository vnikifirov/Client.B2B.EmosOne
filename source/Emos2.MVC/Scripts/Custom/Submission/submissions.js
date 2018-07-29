var routeToSumissionIdAfterSave = 0;
function createSubmission(redirect) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/SubmissionCreate",
        data: { submissionId: 0, "redirect": redirect },
        cache: false
    }).success(function (data) {
        $('#submissionContainer').html('');
        $('#submissionContainer').hide();
        $('#SubmissionCreateContent').html(data);
        $('#SubmissionCreateModal').modal('show');
        $('#SubmissionCreateModal').off('hidden.bs.modal');
        $('#SubmissionCreateModal').on('hidden.bs.modal', function () {
            $('#SubmissionCreateContent').html('');
        });
        initRichTextEditor('#roundCriticalCommentRichText textarea#CriticalJustification', 150);
        $(".ctrlMultiSelect").multiselect({ buttonWidth: '200px', numberDisplayed: 5 });
        setCriticalOnClickEvent();
        setSubmissionCreateFormState();

        $('select[readonly] option:not(:selected)').attr('disabled', true);
    }).always(function () {
        hideLoader();
    });

}

function submissionCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {

        var submission = JSON.parse(data.Data);

        if (!submission.Redirect) {
            $('#SubmissionCreateModal').on('hidden.bs.modal', function () {
                $('#SubmissionCreateContent').html('');
                openSubmission(submission.Id, true);
                refreshSubmissionGrid();
            })
            $('#SubmissionCreateModal').modal('hide');
        }
        else {
            $('#SubmissionCreateModal').modal('hide');
            $('#SubmissionCreateContent').html('');
            redirectToSubmission('/Submission/Submissions', submission.Id);
        }
    }
    hideLoader();
   
}

function diagnosisCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {
        $('#diagnosisCreateModal').on('hidden.bs.modal', function () {
            $('#diagnosisCreateContent').html('');
            refreshDiagnosisGrid();
            refreshSumaryDiagnosisGrid();
        })
        $('#diagnosisCreateModal').modal('hide');
    }
    hideLoader();
}

function sickLeaveDateCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {
        $('#sickLeaveDateCreateModal').on('hidden.bs.modal', function () {
            $('#sickLeaveDateCreateContent').html('');
            var sld = JSON.parse(data.Data);
            refreshSickLeaveDatesGrid();
            refreshSummarySickLeaveDatesGrid();

        })
        $('#sickLeaveDateCreateModal').modal('hide');
    }

    hideLoader();
}


function submissionSaveSuccess(data) {

    if (routeToSumissionIdAfterSave == 0 || !data.IsSuccess) {
        showMessage(data);
    }

    if (data.IsSuccess)
    {
        setSubmissionSaveFormState();
       
        //showMessage(data);
        refreshSubmissionGrid();
        var submission = JSON.parse(data.Data);
        updateSubmissionSummaryTab(submission.Id);
        RefreshCounters();

        if (routeToSumissionIdAfterSave > 0) {

            showRouteModal(routeToSumissionIdAfterSave, false);
            routeToSumissionIdAfterSave = 0;
        }

    }

   
}

function onBeginAjaxPostCreateSubmission(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}

function setSubmissionSaveFormState() {
    var $form = $('#submissionSaveForm');
    $form.data('form-init-state', $form.serialize());
}


function onBeginAjaxPostCreateDiagnosis(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}


function onBeginAjaxPostCreateSickLeaveDate(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}


function onBeginAjaxPost(xhr) {
    var token = getAntiForgeryToken();
    xhr.setRequestHeader("__RequestVerificationToken", token);
}


function setSubmissionCreateFormState() {
    var $form = $('#submissionCreateForm');
    $form.data('form-init-state', $form.serialize());
}

function setDiagnosisCreateFormState() {
    var $form = $('#diagnosisCreateForm');
    $form.data('form-init-state', $form.serialize());
}

function setSickLeaveDateCreateFormState() {
    var $form = $('#sickLeaveDateCreateForm');
    $form.data('form-init-state', $form.serialize());
}

function setAttachmentCreateFormState() {
    var $form = $('#SubmissionAttachmentCreate');
    $form.data('form-init-state', $form.serialize());
}


function getSearchData() {
    var searchData = {};

    searchData.SearchOption = $('.js-submission-search-option').find("option:selected").val();
    searchData.SearchCriteria = $('.js-submission-search').val();

    return searchData;
}


function refreshSubmissionGrid() {

    var gridState = getGridState('submissionGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Submission/SubmissionsGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "redirect": redirect }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#submissionGrid').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
    }).always(function () {
        hideLoader();
    });
}



function refreshDiagnosisGrid() {

    var submissionID = $("#diagnosisGrid").attr("parententity");
    var gridState = getGridState('diagnosisGrid');
    if (submissionID == undefined) {
        return false;
    }
    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Submission/DiagnosisGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionID }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#diagnosisGrid').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
    }).always(function () {
        hideLoader();
    });
}


function refreshSumaryDiagnosisGrid() {

    var submissionID = $("#diagnosisGrid-Summary").attr("parententity");
    var gridState = getGridState('diagnosisGrid-Summary');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Submission/SummaryDiagnosisGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionID }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#diagnosisGrid-Summary').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
    }).always(function () {
        hideLoader();
    });
}


function getSearchParam(searchData) {
    return searchData.SearchOption === "2" ? '?viewAll=True' : '';
}



function openSubmission(submissionID, scrollToDetails) {

    history.replaceState(null, "", "/Submission/Submissions?opensubmission=" + submissionID);
    if (!$('#submissionContainer').length)
        return;

    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/Submission",
        data: { submissionId: submissionID },
        cache: false
    }).success(function (data) {
        $('#submissionContainer').html(data);
        $('#submissionContainer').show();

        $('#js-submission-grid tr').removeClass('row-select');
        $('#js-submission-grid tr[data-submission-id=' + submissionID + ']').addClass('row-select');

        $('select[readonly] option:not(:selected)').hide();


        if (scrollToDetails) {
            $('html, body').animate({
                scrollTop: $("#submissionContainer").offset().top
            }, 1000);
        }

        if (submissionID > 0) {
            $("#containerSubmissionSummary").show();
        }
        else {
            $("#containerSubmissionSummary").hide();
        }

        var typeId = $('#TypeId').val();
        var subTypeId = $('#SubTypeId').val();

        setCriticalOnClickEvent();
        checkReadOnly('containerSaveSubmission');
        disableSubmissionFields();
        readOnlyException();
        setResumbissionOnClickEvent();
        // must be last called
        setSubmissionSaveFormState();
        if (!data.IsSuccess && data.Message != undefined ) {
            self.showErrorMessage(data.Message);
        }
    }).always(function () {
        hideLoader();
        loadSubmissionTabs(submissionID);
    });
}

function deleteSubmission(submissionId) {

    confirmDialog('Are you sure you want to delete selected record?', _deleteSubmissionOkBtnClick);

    function _deleteSubmissionOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/DeleteSubmission",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { submissionId: submissionId },
            cache: false
        })
            .success(function (data) {

                showMessage(data);
                refreshSubmissionGrid();
                closeSubmission();

            });
    }
}
function disableSubmissionFields() {




}
function checkReadOnly(containerId) {
    if ($('#IsReadOnly').val() == 1) {
        $('#' + containerId + ' input, #' + containerId + ' select, #' + containerId + ' button').attr('disabled', 'disabled');
        $('#' + containerId + ' .enabled-panel').attr("onclick", '');
        $('#' + containerId + ' .enabled-panel').attr("style", '');
        $('#' + containerId + ' .enabled-panel').addClass("disabled-panel", '').removeClass('enabled-panel');
        $('#' + containerId + ' .edit-link').hide();
        $('#' + containerId + ' .table-title a').hide();
        $('#' + containerId + ' .action-link').hide();
        $('#' + containerId + ' button[data-dismiss="modal"]').removeAttr('disabled');
        $('#' + containerId + ' button.close').removeAttr('disabled');
    }

    //var onclickAction = $('#' + bidderCreateContent + ' #executiveOfficeRecommendationRichText').find('.edit-link').attr('onclick');
    //$('#' + containerId + ' #executiveOfficeRecommendationRichText').find('.disabled-panel').removeClass('enabled-panel').addClass('disabled-panel');
    //$('#' + containerId + ' #executiveOfficeRecommendationRichText').find('.enabled-panel').attr('onclick', '');

    ////var onclickAction = $('#' + bidderCreateContent + ' #TBSupportRecommendationnRichText').find('.edit-link').attr('onclick');
    //$('#' + containerId + ' #TBSupportRecommendationnRichText').find('.disabled-panel').removeClass('enabled-panel').addClass('disabled-panel');
    //$('#' + containerId + ' #TBSupportRecommendationnRichText').find('.enabled-panel').attr('onclick', '');
}

function setSubmissionSaveFormState() {
    var $form = $('#submissionSaveForm');
    $form.data('form-init-state', $form.serialize());
}


function setDiagnosisSaveFormState() {
    var $form = $('#diagnosisCreateForm');
    $form.data('form-init-state', $form.serialize());
}

function setSickLeaveDateSaveFormState() {
    var $form = $('#sickLeaveDateCreateForm');
    $form.data('form-init-state', $form.serialize());
}


function loadSubmissionTabs(submissionId) {
    //loadSubmissionTab(submissionId, "tab_sub_history", "History");
    //loadSubmissionTab(submissionId, "clarificationGrid", "Clarification");
}



function loadSubmissionTab(submissionId, containerId, action, onLoadFunction) {
    $('#' + containerId)
        .load('/Submission/' + action + '?now=' +
        (new Date()).getTime() +
        '&submissionId=' +
        submissionId,
        onLoadFunction);
}


function closeSubmission() {
    $('#submissionContainer').hide();
    $('#submissionContainer').empty();
    history.replaceState(null, "", "/Submission/Submissions");
}


function readOnlyException() {
 
    $('#IsReadOnly').removeAttr('disabled');
    $('#TypeId').removeAttr('disabled');
  

    $('#CriticalJustification').removeAttr('disabled');
    $('#roundCriticalCommentRichText').find('#CriticalJustification').removeAttr('disabled');
    $('#roundCriticalCommentRichText').find('.edit-link').removeAttr('style');
    var onclickAction = $('#roundCriticalCommentRichText').find('.edit-link').attr('onclick');
    $('#roundCriticalCommentRichText').find('.disabled-panel').removeClass('disabled-panel').addClass('enabled-panel');
    $('#roundCriticalCommentRichText').find('.enabled-panel').attr('onclick', onclickAction);
    $('#CurrentStateId').removeAttr('disabled');


    //exception for submisison select subtypes
    $("#SelectedSubmissionSubTypes").removeAttr("disabled");
    $("#SelectedSickLeaveDateDiagnoses").removeAttr("disabled");

    var canEditComments = $("#canEditComments").val() == "True";

    if (canEditComments)
    {

        $('#SubmissionDecision_Comments').removeAttr('disabled');
        $('#SubmissionDecisionCommentsRichText').find('.edit-link').removeAttr('style');
        var onclickAction = $('#SubmissionDecisionCommentsRichText').find('.edit-link').attr('onclick');
        $('#SubmissionDecisionCommentsRichText').find('.disabled-panel').removeClass('disabled-panel').addClass('enabled-panel');
        $('#SubmissionDecisionCommentsRichText').find('.enabled-panel').attr('onclick', onclickAction);
        $('#btnSaveSubmissionDetailsComment').removeAttr('disabled');

    }

    //sick leave date form
    var CanEditSickLeaveApprove = $("#CanEditSickLeaveApprove").val() == "True";
    if (CanEditSickLeaveApprove)
    {
        $('#Approved').removeAttr('disabled');
        $('#btnSickLeaveCreateOk').removeAttr('disabled');
        $('#sickLeaveDateCreateForm > #Id').removeAttr('disabled');
        $('#sickLeaveDateCreateForm > #SubmissionId').removeAttr('disabled');
        $('#sickLeaveDateCreateForm > #CanEditApprove').removeAttr('disabled');

        $('#sickLeaveDatesSummaryGrid .input-approved-number-of-days').removeAttr('disabled');
        $('#sickLeaveDatesSummaryGrid .btn-approved-number-of-days').removeAttr('disabled');
    }
    else
    {
    	$('#sickLeaveDatesSummaryGrid .btn-approved-number-of-days').hide();
        $('#Approved').attr('disabled','disabled');

    }

    if (!CanEditSickLeaveApprove && $('#IsReadOnly').val() == 0) {
        $('#sickLeaveDatesSummaryGrid .input-approved-number-of-days').attr("disabled", true);
    }


    //clarifitaion add link
    $('#btnAddClarification').css("display", "inline");


}

function createDiagnosis(submissionId) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/DiagnosisCreate",
        data: { diagnosisId: 0, submissionId: submissionId },
        cache: false
    }).success(function (data) {
        $('#diagnosisContainer').html('');
        $('#diagnosisContainer').hide();
        $('#diagnosisCreateContent').html(data);
        $('#diagnosisCreateModal').modal('show');
        $('#diagnosisCreateModal').off('hidden.bs.modal');
        $('#diagnosisCreateModal').on('hidden.bs.modal', function () {
            $('#diagnosisCreateContent').html('');
        });
        initRichTextEditor('#DiagnosisDescriptionRichText textarea#Description', 150);
        initRichTextEditor('#DiagnosisRemarksRichText textarea#Remarks', 150);
        //setCriticalOnClickEvent();

        setDiagnosisCreateFormState();

        $('select[readonly] option:not(:selected)').attr('disabled', true);
    }).always(function () {
        hideLoader();
    });
}


function openDiagnosis(diagnosisID) {

    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/Diagnosis",
        data: { diagnosisId: diagnosisID },
        cache: false
    }).success(function (data) {
        $('#diagnosisCreateContent').html(data);
        $('#diagnosisCreateModal').modal('show');

        $('#js-diagnosis-grid tr').removeClass('row-select');
        $('#js-diagnosis-grid tr[data-diagnosis-id=' + diagnosisID + ']').addClass('row-select');

        $('select[readonly] option:not(:selected)').hide();
        initRichTextEditor('#DiagnosisDescriptionRichText textarea#Description', 150);
        initRichTextEditor('#DiagnosisRemarksRichText textarea#Remarks', 150);
        checkReadOnly('diagnosisCreateContent');
        setDiagnosisSaveFormState();
    }).always(function () {
        hideLoader();
    });
}


//Sick Leave Dates

function openSickLeaveDate(sickLeaveDateId) {
	showLoader()
	
	var canEditElement = $("#CanEditSickLeaveApprove");
	var canEditSickLeaveDate = ($(canEditElement).length) ? $(canEditElement).val() : false;
	var readOnly = $("#IsReadOnly").val();

    $.ajax({
        method: "GET",
        url: "/Submission/SickLeaveDate",
        data: { sickLeaveDateId: sickLeaveDateId, canEditSickLeaveApprove: canEditSickLeaveDate },
        cache: false
    }).success(function (data) {
        $('#sickLeaveDateCreateContent').html(data);
        $('#sickLeaveDateCreateModal').modal('show');

        $('#js-sickleave-grid tr').removeClass('row-select');
        $('#js-sickleave-grid tr[data-sickleavedate-id=' + sickLeaveDateId + ']').addClass('row-select');

        $('select[readonly] option:not(:selected)').hide();
        initRichTextEditor('#SickLeaveDateRemarksRichText textarea#Remarks', 150);
        $(".ctrlMultiSelect").multiselect({ buttonWidth: '745px', numberDisplayed: 10, allSelectedText: false });
        $("#IsReadOnly").val(readOnly);
        checkReadOnly('sickLeaveDateCreateContent');
        setSickLeaveDateSaveFormState();
        readOnlyException();
    }).always(function () {
        hideLoader();
    });
}

function createSickLeaveDate(submissionId) {
	showLoader()

	var canEditElement = $("#CanEditSickLeaveApprove");
	var canEditSickLeaveDate = ($(canEditElement).length) ? $(canEditElement).val() : false;

    $.ajax({
        method: "GET",
        url: "/Submission/SickLeaveDateCreate",
        data: { sickLeaveDateId: 0, submissionId: submissionId, canEditSickLeaveApprove: canEditSickLeaveDate },
        cache: false
    }).success(function (data) {
        $('#sickLeaveContainer').html('');
        $('#sickLeaveContainer').hide();
        $('#sickLeaveDateCreateContent').html(data);
        $('#sickLeaveDateCreateModal').modal('show');
        $('#sickLeaveDateCreateModal').off('hidden.bs.modal');
        $('#sickLeaveDateCreateModal').on('hidden.bs.modal', function () {
            $('#sickLeaveDateCreateContent').html('');
        });
        initRichTextEditor('#SickLeaveDateRemarksRichText textarea#Remarks', 150);
        $(".ctrlMultiSelect").multiselect({ buttonWidth: '745px', numberDisplayed: 10, allSelectedText: false });
        setSickLeaveDateCreateFormState();

        $('select[readonly] option:not(:selected)').attr('disabled', true);
        readOnlyException();
    }).always(function () {
        hideLoader();
    });
}


function refreshSickLeaveDatesGrid() {

    var submissionID = $("#sickLeaveDatesGrid").attr("parententity");
    var gridState = getGridState('sickLeaveDatesGrid');
    if (submissionID == undefined) {
        return false;
    }
    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Submission/SickLeaveDates",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionID }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#sickLeaveDatesGrid').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));

        checkReadOnly('containerSaveSubmission');
        readOnlyException();

    }).always(function () {
        hideLoader();
    });
}

function refreshSummarySickLeaveDatesGrid() {

    var submissionID = $("#sickLeaveDatesSummaryGrid").attr("parententity")
    var gridState = getGridState('sickLeaveDatesSummaryGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Submission/SummarySickLeaveDates",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionID }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#sickLeaveDatesSummaryGrid').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
    }).always(function () {
        hideLoader();
    });
}


//End Sick Leave Dates

function openAttachment(attachmentId, submissionId) {

    $.ajax({
        method: "GET",
        url: "/Submission/AttachmentCreate",
        data: { attachmentId: 0, submissionId: submissionId },
        cache: false
    }).success(function (data) {
        $('#attachmentCreateContent').html(data);
        $('#attachmentCreateModal').modal('show');
        $('#attachmentCreateModal').off('hidden.bs.modal');
        $('#attachmentCreateModal').on('hidden.bs.modal', function () {
            $('#attachmentCreateContent').html('');
        })

        $("#SubmissionAttachmentCreate").submit(function (event) {
            showLoader();
            event.preventDefault();
            //grab all form data  
            debugger;
            var formData = new FormData($(this)[0]);

            $.ajax({
                url: '/Submission/SaveAttachment',
                type: 'POST',
                headers: { "__RequestVerificationToken": getAntiForgeryToken() },
                data: formData,
                async: true,
                cache: false,
                contentType: false,
                processData: false,
                success: function (returndata) {
                    submissionAttachmentSaveSuccess(returndata)
                },
                error: function () {
                    alert("error in ajax form submission");
                }
            });

            return false;



        });

    });

}

function submissionAttachmentSaveSuccess(data) {
    hideLoader();
    showMessage(data);
    if (data.IsSuccess) {
        $('#attachmentCreateModal').modal('hide');
        var attachment = JSON.parse(data.Data);
        refreshAttachmentGrid();
    }

}


function refreshAttachmentGrid() {

    var submissionId = $("#attachmentGrid").attr("parententity");
    var gridState = getGridState('attachmentGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();


    $.ajax({
        method: "POST",
        url: "/Submission/Attachments",
        data: { "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionId },
        cache: false
    }).success((data) => {
        $('#attachmentGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}

function refreshHistoryGrid(maximoId) {


    var gridState = getGridState('historyGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();


    $.ajax({
        method: "POST",
        url: "/Submission/History",
        data: { "gridStateModel": gridState, "searchData": searchData, "maximoId": maximoId },
        cache: false
    }).success(function (data){
        $('#historyGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}

function openHistorySubmissionDetails(submissionId) {

    $.ajax({
        method: "GET",
        url: "/Submission/HistorySubmissionDetails",
        data: { submissionId: submissionId },
        cache: false
    }).success(function (data) {
        $('#historySubmissionDetailsModalContent').html(data);
        $('#historySubmissionDetailsModalWindow').modal('show');
        $('#historySubmissionDetailsModalWindow').off('hidden.bs.modal');
        $('#historySubmissionDetailsModalWindow').on('hidden.bs.modal', function () {
            $('#historySubmissionDetailsModalContent').html('');
        });
        checkReadOnly("historySubmissionDetailsModalContent");

    });
}



function showAttachmentDocument(attachmentId) {
    window.open('/Submission/DownloadAttachment?attachmentId=' + attachmentId);
}


function toogleElementsCreateSubmission() {
    var currentType = $("select#TypeId").val();
    var currentSubType = $("select#SelectedSubmissionSubTypes").val();
    var resubmission = $('#submissionCreateForm #Resumbission');


    function _disableElement(el) {
        el.val('');
        el.attr('disabled', 'disabled');
        el.removeAttr('checked');
    }
    function _enableElement(el) {
        el.removeAttr('disabled');
    }
}



//end Attachment



function updateSubmissionSummaryTab(submissionId) {
    $.ajax({
        method: "GET",
        url: "/Submission/SubmissionSummaryTab",
        cache: false,
        data: { submissionId: submissionId },
    }).success(function (data) {
        setSubmissionSaveFormState();
        $('#tab_sub_summary').html(data);
        $(".summary-multiselect .ctrlMultiSelect").multiselect({ buttonWidth: '315px', numberDisplayed: 5, allSelectedText: false });
        $(".summary-multiselect .ctrlMultiSelect").multiselect('rebuild');
        $(".summary-multiselect .multiselect.dropdown-toggle.btn.btn-default").addClass("disabled");
        refreshDiagnosisGrid();
        refreshSickLeaveDatesGrid();

    }).always(function () {
        hideLoader();
    });
}


function selectSubmissionType(type_id) {
    var el = $("#dropDownstringsubmissionGridTypeId");
    el.val(type_id);
    filterGrid('refreshSubmissionGrid');
}



var paramSubmission = "opensubmission";

function redirectToSubmission(location, submissionId) {
    window.location.href = location + "?" + paramSubmission + "=" + submissionId;
}

$(function () {
    $('.s-redirect-sumission').on('click', function () {
        var location = $(this).data("location");
        var submissionId = $(this).data("submission-id");
        window.location.href = location + "?" + paramSubmission + "=" + submissionId;
    });
});

$(function () {
    var value = getParameterByName(paramSubmission);

    if (value.length) {
        openSubmission(value, true);
    }
});





function deleteDiagnosis(event, diagnosisId, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteDiagnosisOkBtnClick);

    function _deleteDiagnosisOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/DiagnosisDelete",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { diagnosisId: diagnosisId },
            cache: false
        })
        .success((data) => {
            showMessage(data);
            refreshDiagnosisGrid();

        });
    }
}

function deleteSickLeaveDate(event, sickLeaveDateId, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteSickLeaveDateOkBtnClick);

    function _deleteSickLeaveDateOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/SickLeaveDateDelete",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { sickLeaveDateId: sickLeaveDateId },
            cache: false
        })
        .success((data) => {

            showMessage(data);
            refreshSickLeaveDatesGrid();

        });
    }
}


function deleteAttachment(event, attachmentId, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteAttachmentOkBtnClick);

    function _deleteAttachmentOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/AttachmentDelete",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { attachmentId: attachmentId },
            cache: false
        })
        .success((data) => {

            showMessage(data);
            refreshAttachmentGrid();

        });
    }
}


function createPreEmploymentFWSubmission(parentSubmissionId, submissionId, edit) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/PreEmploymentFWSubmissionCreate",
        data: { parentSubmissionId: parentSubmissionId, currentSubmissionId: submissionId, edit: edit },
        cache: false
    }).success(function (data) {
        $('#preemploymentFWCreateContent').html(data);
        $('#preemploymentFWCreateModal').modal('show');
        $('#preemploymentFWCreateModal').off('hidden.bs.modal');
        $('#preemploymentFWCreateModal').on('hidden.bs.modal', function () {
            $('#preemploymentFWCreateContent').html('');
        });
        initRichTextEditor('#roundCriticalCommentRichText textarea#CriticalJustification', 150);
        $(".ctrlMultiSelect").multiselect({ buttonWidth: '200px', numberDisplayed: 5 });
        setCriticalOnClickEvent();
        checkReadOnly('preemploymentFWCreateModal');

        setSubmissionCreateFormState();

        $('select[readonly] option:not(:selected)').attr('disabled', true);
    }).always(function () {
        hideLoader();
    });

}

//cancel form 
function cancelPreEmploymentChildSubmission(submissionId) {
    //delete submission
    $.ajax({
        method: "POST",
        url: "/Submission/DeleteSubmission",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: { submissionId: submissionId },
        cache: false
    })
    .success((data) => {

    });
}


function deleteFWSubmission(event, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteSubmissionOkBtnClick);

    function _deleteSubmissionOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/DeleteSubmission",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { submissionId: submissionId },
            cache: false
        })
            .success((data) => {
                refreshpreemploymentFWSubmissionGrid();
            });
    }

}

function deleteDBSubmission(event, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteSubmissionOkBtnClick);

    function _deleteSubmissionOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Submission/DeleteSubmission",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { submissionId: submissionId },
            cache: false
        })
            .success((data) => {
                refreshpreemploymentDBSubmissionGrid();
            });
    }

}




function preEmploymentFWSubmissionCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {
        $('#preemploymentFWCreateModal').on('hidden.bs.modal', function () {
            $('#preemploymentFWCreateContent').html('');
            refreshpreemploymentFWSubmissionGrid();
        })
        $('#preemploymentFWCreateModal').modal('hide');
    }

    hideLoader();
}

function onBeginAjaxPostCreateSubmissionPreEmploymentFW(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}




function refreshpreemploymentFWSubmissionGrid() {

    var gridState = getGridState('preemploymentFWSubmissionGrid');
    var submissionId = $("#preemploymentFWSubmissionGrid").attr("parententity");


    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();


    $.ajax({
        method: "POST",
        url: "/Submission/PreEmploymentFitnessForWorkSubmissions",
        data: { "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionId },
        cache: false
    }).success((data) => {
        $('#preemploymentFWSubmissionGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}




//preemployment disablity
function createPreEmploymentDBSubmission(parentSubmissionId, submissionId, edit) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/Submission/PreEmploymentDBSubmissionCreate",
        data: { parentSubmissionId: parentSubmissionId, currentSubmissionId: submissionId, edit: edit },
        cache: false
    }).success(function (data) {
        $('#preemploymentDBCreateContent').html(data);
        $('#preemploymentDBCreateModal').modal('show');
        $('#preemploymentDBCreateModal').off('hidden.bs.modal');
        $('#preemploymentDBCreateModal').on('hidden.bs.modal', function () {
            $('#preemploymentDBCreateContent').html('');
        });
        initRichTextEditor('#roundCriticalCommentRichText textarea#CriticalJustification', 150);
        $(".ctrlMultiSelect").multiselect({ buttonWidth: '200px', numberDisplayed: 5 });
        setCriticalOnClickEvent();
        checkReadOnly('preemploymentDBCreateContent');
        setSubmissionCreateFormState();

        $('select[readonly] option:not(:selected)').attr('disabled', true);
    }).always(function () {
        hideLoader();
    });

}

function preEmploymentDBSubmissionCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {
        $('#preemploymentDBCreateModal').on('hidden.bs.modal', function () {
            $('#preemploymentDBCreateContent').html('');
            refreshpreemploymentDBSubmissionGrid();
        })
        $('#preemploymentDBCreateModal').modal('hide');
    }

    hideLoader();
}

function onBeginAjaxPostCreateSubmissionPreEmploymentDB(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}


function refreshpreemploymentDBSubmissionGrid() {

    var gridState = getGridState('preemploymentDBSubmissionGrid');
    var submissionId = $("#preemploymentDBSubmissionGrid").attr("parententity");

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();


    $.ajax({
        method: "POST",
        url: "/Submission/PreEmploymentDisabilitySubmissions",
        data: { "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionId },
        cache: false
    }).success((data) => {
        $('#preemploymentDBSubmissionGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}




function verfyEmployee() {

    showLoader();
    var email = $('#txtEmail').val();


    $.ajax({
        method: 'GET',
        url: '/User/VerifyUser',
        data: { email: email },
        success: function (data) {

            if (data.IsSuccess) {
                //alert(data.PhotoBase64);
                var name = data.Model.FirstName + ' ' + data.Model.LastName;
                $('#txtName').val(name);
                $('#txtDirectorate').val(data.Model.DepartmentName);
                $('#txtTitle').val(data.Model.Title);

                if (data.Model.PhotoBase64 != null) {
                    $("#UserPhoto").attr('src', 'data:image/png;base64,' + data.Model.PhotoBase64);
                    $("#PhotoBase64").val(data.Model.PhotoBase64);
                }
                else {
                    $("#UserPhoto").attr('src', '../img/no-image.png');
                    $("#PhotoBase64").val("");
                }
            }
            else {
                //not found

                $('#subtitleMessage').val('User not found. Please try again.');
                $('#txtName').val('');
                $('#txtDirectorate').val('');
                $('#txtTitle').val('');
                $("#UserPhoto").attr('src', '../img/no-image.png');
            }

        }
    }).always(function () { hideLoader(); });
}



/************* submission Route *************/
function showRouteModalWithSave(el, submissionID) {

    if ($('#IsReadOnly').val() == 0) {
        routeToSumissionIdAfterSave = submissionID;
        $(el).closest('form').submit();
    } else if (formHasUnsavedData()) {
        routeToSumissionIdAfterSave = submissionID;
        $(el).closest('form').submit();
    } else {
        //routeToSumissionIdAfterSave = submissionID;
        showRouteModal(submissionID, false);
    } 

}

function showRouteModal(submissionID, returnToOriginator) {
    showLoader();
    $.ajax({
        method: "GET",
        url: "/SubmissionRoute/SubmissionRoute",
        data: { submissionId: submissionID, returnToOriginator: returnToOriginator },
        cache: false
    }).success(function (data) {
        if (data.IsSuccess) {
            $('#WorkflowModalContent').html(data.Data);
            $('#WorkflowModal').modal('show');
            $('#WorkflowModal')
            .on('hidden.bs.modal',
                function () {
                    $('#WorkflowModalContent').html('');
                });
            initRichTextEditor('#WorkflowModalContent textarea');
           // setRouteOnClickEvent();
        } else {
            showMessage(data);
        }
      /*  if (data.IsSuccess) {


        }
        else {
            showMessage(data);
        }*/

    }).always(function () {
        hideLoader();
    });

}

function submissionRouteSuccess(data) {
    showMessage(data);
    if (data.IsSuccess) {
        $('#WorkflowModal').modal('hide');
        refreshSubmissionGrid()
        var model = JSON.parse(data.Data);
        openSubmission(model.SubmissionId, false);
    }
}
/************* submission Route END *************/

$(document).on('hidden.bs.modal', () => {
    if ($("#preemploymentFWCreateContent").children().length > 0) {
        $('body').addClass('modal-open');
    }
    if ($("#preemploymentDBCreateContent").children().length > 0) {
        $('body').addClass('modal-open');
    }

    if ($("#meetingModalContent #meetingSubmssionDetails").length > 0) {
        $('body').addClass('modal-open');
    }
    
});



 

function setupDiagnosisAutoComplete(diagnosisShortDescriptionElement, icd10CodeId,  icd10CodeElement, icdLongDescElement) {
    $('#DiagnosisShortDescription').autocomplete({
        source:  (request, response) => {

            var term = request.term;
           
            $.ajax({
                url: "/Diagnosis/GetICD10CMBySerchText",
                data: { "term": term },
                type: "GET",
                dataType: "json",
                contentType: "application/json;charset=utf-8",
                success: (data) => {

                  var v =  $.map(eval(data), (item)  => {
                      return {

                        longDesc: item["DiagnosisLongDescription"],
                        icd10cmCode: item["Name"],
                        label: item["DiagnosisShortDescription"],
                        value: item["ID"],
                        id: item["ID"]
                        }
                    });

                    response(v);
                },
                error: (data) => {
                    response([]);
                }
            });



        },
        minLength: 3,
        scroll: true,
        select: (event, ui) => {



            $("#" + icd10CodeElement).val(ui.item.icd10cmCode);
            $("#" + icdLongDescElement).val(ui.item.longDesc);
            $("#" + icd10CodeId).val(ui.item.id);
            $("#" + diagnosisShortDescriptionElement).val(ui.item.label);
   


            return false;
        },

    });

}

function RouteDynamic(actionId) {
    // get ddl related to pressed action button
    var selectedDDId = "RouteToUserProfileId_" + actionId;

    // get selected value in proper ddl
    var selectedValue = $("#" + selectedDDId).val();

    // set proper values in hidden fields
    $("#RouteToUserProfileId").val(selectedValue);
    $("#StepActionId").val(actionId);

    // submit form
    $("#dynamicRouteForm").submit();
}

function RefreshCounters() {

    //DB
    var PreviousDisabilityDB = $("#PreviousDisability").val() + "%";
    $("#PreviousDisabilityCircle").html(PreviousDisabilityDB);

    var RecommendedTotalDisabilityDB = $("#RecommendedTotalDisability").val() + "%";
    $("#RecommendedTotalDisabilityCircle").html(RecommendedTotalDisabilityDB);

    var ApprovedTotalDisabilityDB = $("#ApprovedTotalDisability").val() + "%";
    $("#ApprovedTotalDisabilityCircle").html(ApprovedTotalDisabilityDB);


    //RT
    var PreviousDisabilityRT = $("#PreviousDisability").val() + "%";
    $("#PreviousDisabilityRTCircle").html(PreviousDisabilityRT);

    var TotalDisabilityRT = $("#TotalDisability").val() + "%";
    $("#TotalDisabilityRTCircle").html(TotalDisabilityRT);
}