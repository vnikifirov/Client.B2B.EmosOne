
function openMeetingSpecialAttendee(meetingId) {

    clearAndHideMeetingModalWindow();
    showLoader();

    $('#meetingModalContent').load('/MeetingAttendees/MeetingAddSpecialAttendee?meetingID=' + meetingId, function () {

        $('#meetingModalWindow').modal('show');
        hideLoader();
    });
}

function addMeetingSpecialAttendeeSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {

        clearAndHideMeetingModalWindow();

        refreshMeetingSpecialAttendeesGrid();
    }
}

function removeMeetingSpecialAttendee(meetingID, attendeeID) {

    showLoader();

    $.ajax({

        url: '/MeetingAttendees/RemoveMeetingSpecialAttendee',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingId": meetingID, "attendeeId": attendeeID }),
        contentType: 'application/json; charset=utf-8',
        cache: false,
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {

                refreshMeetingSpecialAttendeesGrid();
            }
        }
    }).always(function () { hideLoader(); });
}

function refreshMeetingSpecialAttendeesGrid() {

    var gridState = getGridState('meetingSpecialAttendeesGrid');
    var meetingId = $('#meetingSpecialAttendeesGrid').attr('meeting-id');

    if (!gridState.FilterState.isValid)
        return false;
    
    var searchData = null;
    showLoader();
    $.ajax({
        url: '/MeetingAttendees/MeetingSpecialAttendeesGrid',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "gridStateModel": gridState, "meetingId": meetingId }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $('#meetingSpecialAttendeesGrid').html(data);
        }
    }).always(function () { hideLoader(); });
}

function openMeetingAttendeeConfirmationModal(meetingID, userID, presentDialog) {

    clearAndHideMeetingModalWindow();

    showLoader();

    $('#meetingModalContent').load('/MeetingAttendees/MeetingAttendeeConfirmationModal?meetingID=' + meetingID + '&userID=' + userID + '&presentDialog=' + presentDialog,
        function () {
            hideLoader();
            $('#meetingModalWindow').modal('show');
            initRichTextEditor('#meetingModalWindow textarea');
        });
}

function refreshMeetingAttendeeConfirmation(data, meetingID) {
    
    showMessage(data);
    
    refreshMeetingAttendeesGrid();
    var isQuorumAchieved = $('#meetingQuorumAchieved').prop('checked');
    refreshMeetingUpdateActions(meetingID);

    //data.Model.IsQuorumAchieved && isQuorumAchieved == false
    if (data.Model == 'True' && isQuorumAchieved == false) {
        $('#meetingQuorumAchieved').prop('checked', true);
        $('#QuorumId').prop('disabled', true);
        refreshMeetingsGrid();
        refreshMeetingUpdateHeader(meetingID);
        refreshMeetingUpdateDetails(meetingID);
        refreshMeetingSubmissionsGrid();
        //$('#btnAddMeetingSubmission').hide();

        //!data.Model.IsQuorumAchieved && isQuorumAchieved == true
    } else if (data.Model == 'False' && isQuorumAchieved == true) {
        $('#meetingQuorumAchieved').prop('checked', false);
        //$('#btnAddMeetingSubmission').show();
        refreshMeetingSubmissionsGrid();
    }

    clearAndHideMeetingModalWindow();
}

function refreshMeetingAttendeesGrid() {
   
    var gridState = getGridState('meetingAttendeesGrid');
    var meetingId = $('#meetingAttendeesGrid').attr('meeting-id');

    if (!gridState.FilterState.isValid)
        return false;
    
    var searchData = null;
    showLoader();

    $.ajax({
        url: '/MeetingAttendees/MeetingAttendeesGrid',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "gridStateModel": gridState, "meetingId": meetingId }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $('#meetingAttendeesGrid').html(data);
        }
    }).always(function () { hideLoader(); });
}

function meetingAttendeeConfirmation(meetingID, userID, isConfirmed) {

    showLoader();

    $.ajax({

        url: '/MeetingAttendees/MeetingAttendeeConfirmationByUser',
        type: 'POST',
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        data: JSON.stringify({ "meetingID": meetingID, "userID": userID, "isConfirmed": isConfirmed }),
        contentType: 'application/json; charset=utf-8',
        cache: false,
        success: function (data) {

            showMessage(data);

            if (data.IsSuccess) {

                refreshMeetingAttendeeConfirmation(data, meetingID);
                refreshMeetingSubmissionsGrid()
            }
        }
    }).always(function () { hideLoader(); });
}