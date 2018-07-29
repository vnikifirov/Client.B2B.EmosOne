
function refreshTabMeetingMoMs(meetingId, gridState) {
    showLoader();
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/MeetingMoMsTab",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "meetingID": meetingId, "gridState": gridState }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#tabMeetingMoMs').html(data);
    }).always(function () { hideLoader(); });
}

function saveMeetingMoMs(meetingId) {
    var forms = $('#tabMeetingMoMs').find('form');
    var meetingMoMs = [];

    for (var i = 0; i < forms.length; i++) {

        var form = forms[i];
        var formDataJSON = extractDataFromFormInJSON($(form).attr('id'));

        meetingMoMs.push(formDataJSON);
    }
    
    showLoader();

    $.ajax({

        url: '/MeetingSubmissions/SaveMeetingSubmissionDecisions',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "model": meetingMoMs }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) { }
        }
    }).always(function () { hideLoader(); });
}

function sendMeetingMoMsToChairman(meetingId) {
    showLoader();
    var gridState = getGridState('meetingSubmissionsGrid');
    var forms = $('#tabMeetingMoMs').find('form');
    var meetingMoMs = [];

    for (var i = 0; i < forms.length; i++) {

        var form = forms[i];
        var formDataJSON = extractDataFromFormInJSON($(form).attr('id'));

        meetingMoMs.push(formDataJSON);
    }

    showLoader();

    $.ajax({

        url: '/MeetingSubmissions/SaveMeetingSubmissionDecisions',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "model": meetingMoMs }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {
                $.ajax({

                    url: '/MeetingSubmissions/SendMeetingMoMsToChairman',
                    type: 'POST',
                    headers: { "__RequestVerificationToken": getAntiForgeryToken() },
                    data: JSON.stringify({ "meetingId": meetingId }),
                    contentType: 'application/json; charset=utf-8',
                    success: function (data) {

                        showMessage(data);

                        if (data.IsSuccess) {
                            refreshMeetingUpdateActions(meetingId);
                            refreshMeetingUpdateDetails(meetingId);
                            refreshTabMeetingMoMs(meetingId, gridState);
                        }
                    }
                }).always(function () { hideLoader(); });

            }
        }
    }).always(function () { hideLoader(); });

}

function setMeetingMoMsStatus(meetingId, isApproved) {
    var gridState = getGridState('meetingSubmissionsGrid');
    showLoader();

    $.ajax({

        url: '/MeetingSubmissions/SetMeetingMoMsStatus',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingId": meetingId, "isApproved": isApproved }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {
                refreshMeetingUpdateActions(meetingId);
                if (isApproved) {
                    refreshMeetingUpdateHeader(meetingId);
                    refreshTabMeetingMoMs(meetingId, gridState);
                    refreshMeetingsGrid();
                } else {
                    refreshTabMeetingMoMs(meetingId, gridState);
                }

                refreshMeetingUpdateDetails(meetingId)
            }
        }
    }).always(function () { hideLoader(); });
}



function saveSubmissionDetailsComment(meetingId, submissionId) {
    var comments = $('#SubmissionDecision_Comments').val();
   
    showLoader();
    $.ajax({
        method: "POST",
        url: "/MeetingSubmissions/SetMeetingSubmissionComments",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "meetingId": meetingId, "submissionId": submissionId, "comment": comments }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        showMessage(data);
        $('#TenderBoardSubmissionComments').html(comments);
        //$('#TenderBoardComments' + submissionId).html(comments);
        //$('#TenderBoardComments').val(comments);

    }).error(function (data) {
        var ss = ""
    }).always(function () { hideLoader(); });
}