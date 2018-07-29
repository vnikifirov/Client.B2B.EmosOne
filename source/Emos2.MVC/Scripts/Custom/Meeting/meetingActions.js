
var sendInvitationAfterSave = false;

function refreshMeetingUpdateActions(meetingID) {
    showLoader();
    $('#meetingUpdateActions').load('/Meeting/MeetingUpdateActions?meetingID=' + meetingID, function () { hideLoader(); });
}

function refreshMeetingUpdateHeader(meetingID) {
    showLoader();
    $('#meetingUpdateHeader').load('/Meeting/MeetingUpdateHeader?meetingID=' + meetingID, function () { hideLoader(); });
}

function meetingUpdateDetailsSuccess(data) {

    var modelData = jQuery.parseJSON(data.Data);

    if (!sendInvitationAfterSave) {

        showMessage(data);
    }

    if (data.IsSuccess) {

        setMeetingUpdateFormState();
        clearAndHideMeetingModalWindow();
        refreshMeetingsGrid();
        refreshMeetingAttendeesGrid();

        if (sendInvitationAfterSave) {
            sendInvitationAfterSave = false;
            sendMeetingInvitationsExecution(modelData.Id);
        }

    }
    else {
        hideLoader();
    }
}

function deleteMeeting(meetingID) {

    confirmDialog('Are you sure you want to delete selected record?', _deleteMeetingOkBtnClick);

    function _deleteMeetingOkBtnClick() {
        showLoader();

        $.ajax({
            url: '/Meeting/DeleteMeeting',
            type: 'POST',
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: JSON.stringify({ "meetingId": meetingID }),
            contentType: 'application/json; charset=utf-8',
            success: function (data) {

                showMessage(data);

                if (data.IsSuccess) {
                    clearAndHideMeetingUpdateContainer();
                    refreshMeetingsGrid();
                    //window.location.href = '/Meeting/Meetings';
                }
            }
        })
            .always(function () { hideLoader(); });
    }
}

function sendMeetingInvitations(meetingID) {

    if ($('#meetingSubmissionsGrid tbody tr').length == 0) {
        showMessage({
            IsSuccess: false,
            Message: 'There are no submissions added to this meeting. Invitations cannot be sent.'
        })
        return;
    }

    sendInvitationAfterSave = true;

    //save meeting details before sending invitations
    $('#meetingUpdateForm').submit();

    showLoader();
}

function rescheduleMeeting(meetingID) {
    
    showLoader();

    $.ajax({

        url: '/Meeting/RescheduleMeeting',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingId": meetingID }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {
                refreshMeetingsGrid();
                openMeeting(meetingID, false);
            }

        }
    }).always(function () { hideLoader(); });
}

function setMeetingOpened(meetingID) {
    
    showLoader();

    $.ajax({

        url: '/Meeting/SetMeetingOpened',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingId": meetingID }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {
                //refreshMeetingUpdateDetails(meetingID);
                //refreshMeetingUpdateActions(meetingID);
                //refreshMeetingUpdateHeader(meetingID);
                refreshMeetingsGrid();
                openMeeting(meetingID, false);
            }
        }
    }).always(function () { hideLoader(); });
}

function setMeetingClosed(meetingID) {
  
    var gridState = getGridState('meetingSubmissionsGrid');
    showLoader();

    $.ajax({

        url: '/Meeting/SetMeetingClosed',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingID": meetingID }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {
                //refreshMeetingUpdateActions(meetingID);
                //refreshMeetingUpdateHeader(meetingID);
                //refreshMeetingUpdateDetails(meetingID);
                //refreshMeetingSubmissionsGrid();
                //refreshTabMeetingMoMs(meetingID, gridState);
                refreshMeetingsGrid();
                openMeeting(meetingID, false);
            }
        }
    }).always(function () { hideLoader(); });
}

function setMeetingFinished(meetingID)
{

    confirmDialog('Are you sure you want to finish meeting?', _finishMeeting);

    function _finishMeeting()
    {
        var gridState = getGridState('meetingSubmissionsGrid');
        showLoader();

        $.ajax({

            url: '/Meeting/SetMeetingFinished',
            type: 'POST',
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: JSON.stringify({ "meetingID": meetingID }),
            contentType: 'application/json; charset=utf-8',
            success: (data) => {
                showMessage(data);

                if (data.IsSuccess) {
                    refreshMeetingsGrid();
                    openMeeting(meetingID, false);
                }
            }
        }).always(() => { hideLoader(); });
    }

  
}




function sendMeetingInvitationsExecution(meetingID) {

    $.ajax({
        url: '/Meeting/SendMeetingInvitations',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingID": meetingID }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {

                //refreshMeetingUpdateHeader(meetingID);
                //refreshMeetingUpdateActions(meetingID);
                //refreshMeetingUpdateDetails(meetingID);
                //refreshMeetingAttendeesGrid();
                refreshMeetingsGrid();
                openMeeting(meetingID, false);
                // If meeting is type of Urgent, model will have value 'true'
                if (data.Model) {

                    $('#btnAddMeetingSubmission').hide();
                }
            }
        }
    }).always(function () { hideLoader(); });
}