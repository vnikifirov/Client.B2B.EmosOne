
function openClarification(clarificationId, originatorId, submissionId) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/Clarification/OpenClarification",
        data: { "clarificationId": clarificationId, "originatorId": originatorId, "submissionId": submissionId },
        cache: false
    }).success(function (data) {
        $('#clarificationCreateContent').html(data);
        $('#clarificationCreateModal').modal('show');
        $('#clarificationCreateModal')
            .on('hidden.bs.modal',
                function() {
                    $('#clarificationCreateContent').html('');
                });
        //initRichTextEditor('#ClarificationCreateContent textarea');
        initRichTextEditor('#messageRichText textarea#Message');
        initRichTextEditor('#responseRichText textarea#Response');
        $('#respondOnClarificationSave').addClass('form-hidden');
        var asd = $('[data-clarification-id=' + (clarificationId) + ']').each(function () {
            var boldTags = $(this).find('b');
            if (boldTags.length > 0) {
                var sss = boldTags[0].innerHTML
                boldTags[0].replaceWith(boldTags[0].innerHTML);
            }

        })
        if (clarificationId = !0) {
            $('#clarificationCreateContent .clarification_document_action').addClass('hidden');
        }

        $('#bootstrapMultiselect').multiselect({
            maxHeight: 200,
            numberDisplayed: 5
        })
    }).always(function () {
        hideLoader();
    });
}

function clarificationCreateSuccess(data) {
    showMessage(data);
    if (data.IsSuccess) {
        refreshClarificationGrid();
        $('#clarificationCreateModal').modal('hide');
    }
}

function refreshClarificationGrid() {

    var gridState = getGridState('clarificationGrid');
    var submissionId;
    if (!submissionId) {
        //submissionId = $('#submissionId').val()
        submissionId = $("#clarificationGrid").attr("parententityid");
    }
    if (!submissionId) {
        submissionId = 0;
    }
    if (!gridState.FilterState.isValid) return false;

    showLoader();
    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/Clarification/ClarificationsGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "submissionId": submissionId }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#clarificationGrid').html(data);
    }).always(function () {
        hideLoader();
    });
}

function clearAndHideClarificationModalWindow() {
    $('#clarificationCreateContent').empty();
    $('#clarificationCreateModal').modal('hide');
}

function respondOnClarification() {
    $('#respondOnClarification').removeClass('show');
    $('#respondMessageOnClarification').addClass('show');
    $('#respondOnClarificationSave').removeClass('form-hidden');
    $('#respondOnClarificationAction').addClass('hidden');
    $("#clarificationCreateModal").animate({
        scrollTop: $("#respondOnClarificationSave").position().top
    }, 1000);
    //$('#respondMessageOnClarification').on('shown.bs.modal', function () {
        tinymce.activeEditor.focus();
        tinyMCE.activeEditor.selection.select(tinyMCE.activeEditor.getBody(), true);
        tinyMCE.activeEditor.selection.collapse(false);
    //})
}

function saveRespond() {
    var id = $('#Id').val();
    var message = tinyMCE.activeEditor.getContent()
    showLoader();
    $.ajax({
        method: "POST",
        url: "/Clarification/SaveClarificationRespond",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "message": message, "clarificationId": id }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        showMessage(data);
        saveRespondSuccess(id);
    }).always(function () {
        hideLoader();
    });
}

function saveRespondSuccess(clarificationId) {
    var submissionId = $('#submissionId').val();
    if (!submissionId) {
        submissionId = 0;
    }
    openClarification(clarificationId,0,submissionId);
}


function closeClarification(clarificationId, submissionId) {

    confirmDialog('Are you sure you want to archive clarification?', _closeClrificationOkButtonPressed);

    function _closeClrificationOkButtonPressed() {
        showLoader()
        $.ajax({
            method: "POST",
            url: "/Clarification/CloseClarification",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            cache: false,
            data: JSON.stringify({ "clarificationId": clarificationId }),
            contentType: 'application/json; charset=utf-8'
        }).success(function (data) {
            showMessage(data);
            clearAndHideClarificationModalWindow();
            refreshClarificationGrid()
        }).always(function () {
            hideLoader();
        });
    }
}

function deleteClarification(event,clarificationId) {
    event.stopPropagation();
}



function openClarificationAttachment(attachmentId, clarificationId, submissionId) {


    if (clarificationId == 0) {
        
        if ($("#clarificationCreateContent #Id").val() == '0') {
            var form = $("#clarificationCreateContent form")[0];

            $.ajax({
                method: "POST",
                url: $(form).prop("action"),
                headers: { "__RequestVerificationToken": getAntiForgeryToken() },
                data: $(form).serialize(),
                cache: false,
                async: false
            }).success(function (data) {
                if (data.IsSuccess) {
                    $("#clarificationCreateContent #Id").val(data.Data);
                    var typeID = parseInt($("#clarificationCreateContent #TypeId").val());

                    refreshClarificationGrid($("#clarificationCreateContent #ClarificationId").val());

                }
                else {
                    showMessage(data);

                }
            });

        }
        clarificationId = $("#clarificationCreateContent #Id").val();

        if (clarificationId == 0) {
            return;
        }
    }

    $.ajax({
        method: "GET",
        url: "/Clarification/ClarificationAttachmentCreate",
        data: { attachmentId: 0, clarificationId: clarificationId, submissionId: submissionId },
        cache: false
    }).success(function (data) {
        $('#ClarificationAttachmentCreateContent').html(data);
        $('#ClarificationAttachmentCreateModal').modal('show');
        $('#ClarificationAttachmentCreateModal').off('hidden.bs.modal');
        $('#ClarificationAttachmentCreateModal').on('hidden.bs.modal', function () {
            $('#attachmentCreateContent').html('');
        })

        $("#ClarificationAttachmentCreate").submit(function (event) {
            showLoader();
            event.preventDefault();
            //grab all form data  
            var formData = new FormData($(this)[0]);

            $.ajax({
                url: '/Clarification/SaveClarificationAttachment',
                type: 'POST',
                headers: { "__RequestVerificationToken": getAntiForgeryToken() },
                data: formData,
                async: true,
                cache: false,
                contentType: false,
                processData: false,
                success: function (returndata) {
                    ClarificarionAttachmentSaveSuccess(returndata)
                },
                error: function () {
                    alert("error in ajax form submission");
                }
            });

            return false;



        });

    });

}

function ClarificarionAttachmentSaveSuccess(data) {
    hideLoader();
    showMessage(data);
    if (data.IsSuccess) {
        $('#ClarificationAttachmentCreateModal').modal('hide');
        var attachment = JSON.parse(data.Data);
        refreshClarificationAttachmentGrid(attachment.ClarificationId);
    }

}


function refreshClarificationAttachmentGrid(ClarificationId) {


    var gridState = getGridState('clarificationAttachmentGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var clarificationId = (ClarificationId) ? ClarificationId : $("#clarificationAttachmentGrid").attr("parententityid");
 


    $.ajax({
        method: "POST",
        url: "/Clarification/ClarificationAttachments",
        data: { "gridStateModel": gridState, "searchData": searchData, "clarificationId": clarificationId },
        cache: false
    }).success((data) => {
        $('#clarificationAttachmentGrid').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;
}

function showClarificationAttachmentDocument(attachmentId) {
    window.open('/Clarification/DownloadClarificationAttachment?attachmentId=' + attachmentId);
}

function deleteClarificationAttachment(event, attachmentId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteClarificationAttachmentOkBtnClick);

    function _deleteClarificationAttachmentOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/Clarification/ClarificationAttachmentDelete",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { attachmentId: attachmentId },
            cache: false
        })
            .success((data) => {

                showMessage(data);
                refreshClarificationAttachmentGrid();

            });
    }
}

