
function onBeginAjaxPost(xhr) {
    var token = getAntiForgeryToken();
    xhr.setRequestHeader("__RequestVerificationToken", token);
}

function onBeginAjaxPostWithLoader(xhr) {
    var token = getAntiForgeryToken();
    showLoader();
    xhr.setRequestHeader("__RequestVerificationToken", token);
}

function onBeginCrudActions(xhr, settings) {
    var token = getAntiForgeryToken();
    xhr.setRequestHeader("__RequestVerificationToken", token);

    //var searchData = getMeetingsGridSearchData();

    //settings.data += '&SearchOption=' + searchData.SearchOption;

    //if (searchData.SearchCriteria != undefined) {

    //    settings.data += '&SearchCriteria=' + searchData.SearchCriteria;
    //}
}

function createMeeting(redirect) {
    clearAndHideMeetingUpdateContainer();
    showLoader();

    $('#meetingModalContent').load('/Meeting/MeetingCreate?redirect=' + redirect + '&timestamp=' + new Date().getTime(), function () {

        hideLoader();
        initRichTextEditor('textarea#CriticalMeetingComment');
        initRichTextEditor('#noteRichText textarea#Note')
        setRoundRobinOnClickEvent();
        setMeetingCreateFormState();

        $('#meetingModalWindow').modal('show');
    });
}

function refreshMeetingUpdateDetails(meetingID) {
    showLoader();
    $('#meetingUpdateDetails').load('/Meeting/MeetingUpdateDetailsRefresh?meetingID=' + meetingID, function () { hideLoader(); });
}

function clearAndHideMeetingUpdateContainer() {
    $('#meetingUpdateContainer').hide();
    $('#meetingUpdateContainer').empty();
    history.replaceState(null, "", "/Meeting/Meetings");
}

function setMeetingCreateFormState() {
    var $createForm = $('#meetingCreateForm');
    $createForm.data('form-init-state', $createForm.serialize());
}

function clearAndHideMeetingModalWindow() {
    $('#meetingModalContent').empty();
    $('#meetingModalWindow').modal('hide');
}

function setRoundRobinOnClickEvent() {

    $('#IsCritical').on('click', function () {
        toggleRoundRobinRichText();
    });

    toggleRoundRobinRichText()
}

function toggleRoundRobinRichText() {
    if ($('input#IsCritical').is(':checked')) {

        $('#roundRobinCommentRichText').addClass('show');
    }
    else {

        $('#roundRobinCommentRichText').removeClass('show');
    }
}

function getMeetingsGridSearchData() {

    var searchData = {};

    searchData.SearchOptionId = $('.js-submission-search-option').find("option:selected").val();
    
    if (!searchData.SearchOptionId)
        searchData.SearchOptionId = 1;
    searchData.SearchCriteria = $('.js-submission-search').val();
    searchData.SelectedMeetingType = $('#selectedMeetingType').val();

    return searchData;
}

function meetingCreateSuccess(data) {

    var modelData = jQuery.parseJSON(data.Data);

    showMessage(data);
    showLoader();

    if (data.IsSuccess) {
        clearAndHideMeetingModalWindow();
        clearAndHideMeetingUpdateContainer();

        if (!modelData.Redirect) {
            openMeeting(modelData.Id, true);
            refreshMeetingsGrid();
        }
        else {
            redirectToMeeting('/Meeting/Meetings', modelData.Id);
        }
        hideLoader();
    } else {
        hideLoader();
    }
}

function selectedMeetingType(meetingTypeId) {
    var el = $("#dropDownstringmeetingsGridMeetingTypeId");
    el.val(meetingTypeId);
    filterGrid('refreshMeetingsGrid');
}

function refreshMeetingsGrid() {
    var gridState = getGridState('meetingsGrid');

    if (!gridState.FilterState.isValid)
        return false;

    var redirect = $('#Redirect').val();
    if (redirect)
        var searchData = getMeetingsGridSearchData();

    showLoader();
    $.ajax({
        url: '/Meeting/MeetingsGrid',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "redirect": redirect }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $('#meetingsGrid').html(data);
            history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
        }
    }).always(function () { hideLoader(); });
}

function redirectToMeeting(location, meetingId) {
    window.location.href = location + "?" + paramMeeting + "=" + meetingId;
}

function openMeeting(meetingID, scrollToDetails) {
    
    if (!$('#meetingUpdateContainer').length)
        return;

    if (formHasUnsavedData()) {
        if (!confirm('Are you sure you want to leave this page?\n\nYou have unsaved changes.'))
            return false;
    }

    history.replaceState(null, "", "/Meeting/Meetings?openmeeting=" + meetingID);

    clearAndHideMeetingModalWindow();
    showLoader();

    $('#meetingUpdateContainer').load('/Meeting/MeetingDetails?meetingId=' + meetingID, function () {

        $('#meetingsGrid tr').removeClass('row-select');
        $('#meetingsGrid tr[data-meeting-id=' + meetingID + ']').addClass('row-select');

        setRoundRobinOnClickEvent();

        $('#meetingUpdateContainer').show();
        if (scrollToDetails == true) {
            $('html, body').animate({

                scrollTop: $('#meetingUpdateContainer').offset().top
            }, 1000);
        }
        setMeetingUpdateFormState();

        hideLoader();
    });
}

function setMeetingUpdateFormState() {
    var $form = $('#meetingUpdateForm');
    $form.data('form-init-state', $form.serialize());
}

let paramMeeting = "openmeeting"

$(function () {
    var value = getParameterByName(paramMeeting);

    if (value.length) {
        openMeeting(value, true);
    }
});
