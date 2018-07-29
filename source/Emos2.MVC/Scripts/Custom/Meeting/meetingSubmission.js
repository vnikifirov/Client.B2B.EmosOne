function openMeetingSubmissionsGridSelection(meetingID) {
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/MeetingSubmissionsGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "meetingID": meetingID, "gridStateModel": '', "isSetForSelection": 'true' }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#meetingModalContent').html(data);
        $('#meetingModalWindow').modal('show');
    }).always(function () { hideLoader(); });
}

function addSelectedSubmissionsToMeeting(meetingId) {
    var gridState = getGridState('meetingSubmissionsGrid');
    var submissionsIDs = $('#meetingModalContent input:checked').map(function () {

        return $(this).attr('submissionid');
    });

    if (submissionsIDs.length == 0) {

        clearAndHideMeetingModalWindow();
        refreshTabMeetingMoMs(meetingId, gridState);

        return;
    }

    showLoader();

    $.ajax({

        url: '/MeetingSubmissions/SetSubmissionsToMeeting',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingID": meetingId, "submissionsIDs": submissionsIDs.get() }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {

                clearAndHideMeetingModalWindow();
                refreshMeetingSubmissionsGrid();
                refreshTabMeetingMoMs(meetingId, gridState);
            }
        }
    }).always(function () { hideLoader(); });
}

function removeSubmissionFromMeeting(event, meetingId, submissionId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteSubmissionFromMeetingOkBtnPressed);
    function _deleteSubmissionFromMeetingOkBtnPressed() {
        var gridState = getGridState('meetingSubmissionsGrid');
        showLoader();

        $.ajax({

            url: '/MeetingSubmissions/RemoveSubmissionFromMeeting',
            type: 'POST',
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: JSON.stringify({ "meetingID": meetingId, "submissionID": submissionId }),
            contentType: 'application/json; charset=utf-8',
            success: function (data) {

                showMessage(data);

                if (data.IsSuccess) {

                    refreshMeetingSubmissionsGrid();
                    refreshTabMeetingMoMs(meetingId, gridState);
                }
            }
        }).always(function () { hideLoader(); });
    }
}

function openMeetingSubmissionDetails(submissionID, meetingID) {

    showLoader();

    $('#meetingModalContent').load('/MeetingSubmissions/MeetingSubmissionDetails?now=' + (new Date()).getTime() + '&submissionID=' + submissionID + '&meetingID=' + meetingID, function () {

        $('#meetingModalWindow').modal('show');
        initRichTextEditor('#meetingModalContent textarea');
        setFinalDecisionOnClickEvent();
        setRQOriginalApprovingAuthorityOnClick();
        setVROriginalApprovingAuthorityOnClick();

        checkReadOnly('sickLeaveDatesSummaryGrid');
        readOnlyException();

        //hide save button if not on Note tab
        $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
            var target = $(e.target).attr("href") // activated tab
            if (target == "#tabNote") {
                $('button.js-btn-save-note').show();
            }
            else {
                $('button.js-btn-save-note').hide();
            }
        });

        $('#meetingSubmissionsGrid table tr').removeClass('row-select');
        $('#meetingSubmissionsGrid table tr[data-meetingsubmission-id=' + submissionID + ']').addClass('row-select');

        hideLoader();
    });
}

function refreshMeetingSubmissionsGrid() {
    var gridState = getGridState('meetingSubmissionsGrid');

    showLoader();
    var meetingID = $('#meetingSubmissionsGrid').find('div.table-responsive').attr('meeting-id');
    
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/MeetingSubmissionsGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "meetingID": meetingID, "gridStateModel": gridState, "isSetForSelection": 'false' }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {

        $('#meetingSubmissionsGrid').html(data);
        refreshTabMeetingMoMs(meetingID, gridState);
    }).always(function () { hideLoader(); });
}

function setMeetingSubmissionDecision(meetingID, submissionID, userID, decisionStatus) {

    showLoader();

    $.ajax({

        url: '/MeetingSubmissions/SetMeetingSubmissionDecision',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingID": meetingID, "submissionID": submissionID, "userID": userID, "decisionStatus": decisionStatus }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {

                refreshMeetingSubmissionsGrid();
                //clearAndHideMeetingModalWindow();
            }
        }
    }).always(function () { hideLoader(); });
}

function refreshMeetingSubmissionsGridSelection() {
    var gridState = getGridState('meetingModalContent');

    showLoader();

    var meetingID = $('#meetingModalContent').find('div.table-responsive').attr('meeting-id');
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/MeetingSubmissionsGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "meetingID": meetingID, "gridStateModel": gridState, "isSetForSelection": 'true' }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#meetingModalContent').html(data);
    }).always(function () { hideLoader(); });
}

function selectSubmissionForMeeting() {
    var isHeaderChecked = $('#selectAllSubmission').is(':checked');
    var submissions = $('*[id^="selectSubmission"]');

    for (x = 0; x < submissions.length; x++) {

        if (isHeaderChecked == true) {

            if (submissions[x].checked != isHeaderChecked) {

                $(submissions[x]).click();
            }
        } else {

            $(submissions[x]).removeAttr('checked');
        }
    }
}

function refreshMeetingSubmissionHistoryGrid(submissionId) {
    
    var gridState = getGridState('meetingSubmissionHistoryGrid');

    if (!gridState.FilterState.isValid)
        return false;
    
    showLoader();
    $.ajax({
        url: '/MeetingSubmissions/MeetingSubmissionHistoryGrid',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "gridStateModel": gridState, "submissionId": 1032}),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $('#meetingSubmissionHistoryGrid').html(data);
        }
    }).always(function () { hideLoader(); });
}

function refreshMeetingSubmissionAttachmentGrid(submissionId) {
    
    var gridState = getGridState('meetingsubmissionAttachmentGrid');

    if (typeof(submission) === typeof(undefined))
    {
        submissionId = $('#meetingsubmissionAttachmentGrid').attr('parententity');
    }
    
    if (!gridState.FilterState.isValid)
        return false;

    showLoader();

    var searchData = getSearchData();
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/MeetingSubmissionAttachments",
        data: { "gridStateModel": gridState, "searchData": searchData, "submissionId": submissionId },
        cache: false
    }).success((data) => {
        $('#meetingsubmissionAttachmentGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}