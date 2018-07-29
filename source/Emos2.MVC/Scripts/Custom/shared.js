/// <reference path="outside.js" />
$.ajaxSetup({ cache: false });

var loader_count = 0;
function showLoader() {
    loader_count = loader_count + 1;
    if (loader_count == 1) {
        $.loader({ className: "blue-with-image-2", content: '' });
    }
}

function hideLoader() {
    if (loader_count > 0) {
        loader_count = loader_count - 1;
    }
    if (loader_count == 0) {
        $.loader('close')
    }
}
function resetRichTextEditor(selector) {
    tinymce.remove(selector);
}

function initRichTextEditor(selector, min_height) {

    resetRichTextEditor(selector);

    if (min_height == null) {
        min_height = 100;
    }

    tinymce.init({

        selector: selector,
        statusbar: false,
        elementpath: false,
        toolbar: 'copy cut paste | undo redo | bold italic underline superscript subscript | alignleft alignright aligncenter alignjustify | bullist numlist | indent outdent | table | upload-image | removeformat',
        plugins: 'table autoresize paste',
        content_css: '/Content/main.css',
        table_default_attributes: {
            border: 1
        },
        paste_preprocess: function(plugin, args) {
            args.content = args.content.replace("<table", "<table border=\"1\" ");
        },
        table_toolbar: 'tabledelete | tableinsertrowbefore tableinsertrowafter tabledeleterow | tableinsertcolbefore tableinsertcolafter tabledeletecol',
        autoresize_min_height: min_height,
        autoresize_bottom_margin: 10,
        menubar: false,
        browser_spellcheck: true,
        setup: function (editor) {

            editor.on('change', function () {
                editor.save();
            });

            if ($('#' + editor.id).attr('disabled')) {

                editor.settings.readonly = true;
            }

            //image upload
            initRichTextEditorImageUploader(editor);
        }

    });


}

function initRichTextEditorImageUploader(editor) {
    $('#tinymce-uploader').off("change");
    $('#tinymce-uploader').on("change", function () {
        var input, file, fr, img;

        if (typeof window.FileReader !== 'function') {
            write("The file API isn't supported on this browser yet.");
            return;
        }

        input = document.getElementById('tinymce-uploader');
        if (!input) {
            alert("Couldn't find the imgfile element.");
        }
        else if (!input.files) {
            alert("This browser doesn't seem to support the `files` property of file inputs.");
        }
        else if (!input.files[0]) {
            alert("Please select a file before clicking 'Load'");
        }
        else {
            file = input.files[0];
            fr = new FileReader();
            fr.onload = createImage;
            fr.readAsDataURL(file);
        }

        function createImage() {
            img = new Image();
            img.src = fr.result;
            editor.insertContent('<img src="' + img.src + '"/>');

        }

    });

    editor.addButton('upload-image', {
        tooltip: "Insert image",
        //text: "IMAGE",
        icon: "image",
        onclick: function (e) {
            //console.log($(e.target).prop("tagName"));

            $('#tinymce-uploader').trigger('click');


        }
    });
}

function openRichTextEditorModal(modelName, title, uniqueClass) {
    resetRichTextEditor('#RichTextEditorControl');

    $('#RichTextEditorTitle').html(title);
    $('#RichTextEditorControl').val($("input[name='" + modelName + "']." + uniqueClass).val());
    $('#RichTextEditorModelName').val(modelName);
    $('#RichTextEditorModelUniqueClass').val(uniqueClass);
    

    initRichTextEditor('#RichTextEditorControl', 300);

    $('#RichTextEditorModal').modal('show');

    $('#RichTextEditorModal').on('shown.bs.modal', function () {
        tinymce.activeEditor.focus();
        tinyMCE.activeEditor.selection.select(tinyMCE.activeEditor.getBody(), true);
        tinyMCE.activeEditor.selection.collapse(false);
    })
}

function saveRichTextEditorModal() {
    var modelName = $('#RichTextEditorModelName').val();
    var uniqueClass = $('#RichTextEditorModelUniqueClass').val();
    var el = $("input[name='" + modelName + "']." + uniqueClass)
    var value = $('#RichTextEditorControl').val()
    el.val(value)
    el.siblings('div.enabled-panel').html(value)
    $('#RichTextEditorModal').modal('hide');
    tinymce.activeEditor.focus();

 
}



function initDatePicker(datePickerID) {

    $('#' + datePickerID).datepicker({
        dateFormat: 'dd/mm/yy',
        firstDay: 1, // 0-6, 1 means Monday
        changeYear: true,
        yearRange: "1930:2030"

    });
}

function initTimePicker(timePickerID) {

    $('#' + timePickerID).timepicker({
        timeFormat: 'HH:mm',
        stepMinute: 5

    });
}

function setCriticalOnClickEvent() {

    $('#Critical').on('click', function () {

        toggleCriticalRichText()
    });
    toggleCriticalRichText()
}


function toggleCriticalRichText() {
    if ($('input#Critical').is(':checked')) {

        $('#roundCriticalCommentRichText').addClass('show');
    }
    else {

        $('#roundCriticalCommentRichText').removeClass('show');
    }
}
function setResumbissionOnClickEvent() {
    $('#Resubmission').on('click', function () {

        toggleResumbissionbinRichText();
    });
    toggleResumbissionbinRichText()
}


function toggleResumbissionbinRichText() {
    if ($('input#Resubmission').is(':checked')) {
        $('#resumbissionComments').addClass('show');
   
    }
    else {
        $('#resumbissionComments').removeClass('show');
    }
}
function setContractOnClickEvent() {

    $('div.ExistingContractApplicable input').on('click', function () {

        toggleContractGrid();
    });
    toggleContractGrid()
}


function toggleContractGrid() {

    if ($('div.ExistingContractApplicable input[value="True"]').is(':checked')) {

        $('#submissionContractsGrid').addClass('show');
    }
    else {

        $('#submissionContractsGrid').removeClass('show');
    }
}

function setAdditionalBidderOnClickEvent() {

    $('div.BidderTypeId input').on('click', function () {

        toggleAdditionalBidderGrid();
    });
    toggleAdditionalBidderGrid()
}


function toggleAdditionalBidderGrid() {

    if ($('div.BidderTypeId input[value="5"]').is(':checked')) {

        $('#additionalBidderGridContainer').addClass('show');
    }
    else {

        $('#additionalBidderGridContainer').removeClass('show');
    }
}

function showMessage(data) {

    if (data.IsSuccess) {

        $(".alert-success p").html(data.Message)
        $(".alert-success").show().delay(3000).fadeOut("slow");
    }
    else {

        $(".alert-error p").html(data.Message)
        $(".alert-error").show().delay(5000).fadeOut("slow");
    }
}
function showErrorMessage(message) {
    $(".alert-error p").html(message)
    $(".alert-error").show().delay(5000).fadeOut("slow");
}
function extractDataFromFormInJSON(formID) {

    var formData = $('#' + formID).serializeArray();

    var formDataObject = {};
    $.each(formData,
        function (i, v) {
            formDataObject[v.name] = v.value;
        });

    return formDataObject;
}

function setRouteOnClickEvent() {

    $('input[name="returnToOriginator"]').on('click', function () {

        toggleRouteToUser();
    });
    toggleRouteToUser()
}


function toggleRouteToUser() {
    $('#RouteToUserID').prop('disabled', !$('#RouteTypeUser').is(':checked'));
}

function getAntiForgeryToken() {

    var token = '';

    if ($('[name=__RequestVerificationToken]').val()) {

        token = $('[name=__RequestVerificationToken]').val();
    }

    return token;
}
function setProposedTenderTypeRQOnClickEvent() {
    var group = $('input[name="submissionRQModel.RQTypeId"]');
    $(group).each(function (index) {
        $(this).click(function () {
            toggleRQElements()
        });
    });
    toggleRQElements()
}

function toggleRQElements() {
    var value = $('#submissionRQModel_RQTypeId:checked').val();
    if (value == 18) {
        $('#BusinessCaseTermination').show();
    } else {
        $('#BusinessCaseTermination').hide();
    }
}

function setRQOriginalApprovingAuthorityOnClick() {
    $('#OriginalApprovedAuthorityContainerRQ input[type="checkbox"]').on('click', function () {
        $(this).prop("checked", true);
        if ($(this).is(":checked")) {
            $("#submissionRQModel_OriginalApprovedAuthorityId").val($(this).val());
        }
        else {
            $("#submissionRQModel_OriginalApprovedAuthorityId").val($(this).val() - 1);
        }

        toogleRQOriginalApprovingAuthority();
    });
    toogleRQOriginalApprovingAuthority()
}
function toogleRQOriginalApprovingAuthority() {
    var maxselected = $("#submissionRQModel_OriginalApprovedAuthorityId").val();
    $('#OriginalApprovedAuthorityContainerRQ input[type="checkbox"]').each(function (index, el) {
        $(el).prop("checked", $(el).val() == maxselected);
        var sss = $(el).prop("checked");
    });
}

function setVROriginalApprovingAuthorityOnClick() {
    $('#OriginalApprovedAuthorityContainerVR input[type="checkbox"]').on('click', function () {
        $(this).prop("checked", true);
        if ($(this).is(":checked")) {
            $("#submissionVRModel_OriginalApprovedAuthorityId").val($(this).val());
        }
        else {
            $("#submissionVRModel_OriginalApprovedAuthorityId").val($(this).val() - 1);
        }
        toogleVROriginalApprovingAuthority();
    });
    toogleVROriginalApprovingAuthority()
}
function toogleVROriginalApprovingAuthority() {
    var maxselected = $("#submissionVRModel_OriginalApprovedAuthorityId").val();
    $('#OriginalApprovedAuthorityContainerVR input[type="checkbox"]').each(function (index, el) {
        $(el).prop("checked", $(el).val() == maxselected);
    });
}

function setFinalDecisionOnClickEvent() {

    $('#FinalDecisionContainer input[type="checkbox"]').on('click', function () {
        $(this).prop("checked", true);
        if ($(this).is(":checked")) {
            $("#FinalDecisionValue").val($(this).val());
        }
        else {
            $("#FinalDecisionValue").val($(this).val() - 1);
        }

        toggleFinalDecision();
    });
    toggleFinalDecision();
}


function toggleFinalDecision() {
    var maxselected = $("#FinalDecisionValue").val();
    var hasTbMeeting = $('#HasTBMeeting').val();
    var hasDirector = $('#HasDirector').val();
    if (maxselected == 5) {
        //$('#FinalDecisionContainer input');
        $('#FinalDecisionContainer input[type="checkbox"]').each(function (index, el) {
            $(el).attr("disabled", "disabled")
            $(el).prop("checked", $(el).val() == 2);
            $("#Endorsement_" + $(el).val()).prop("checked", $(el).val() < 0);
        });
    } else {
        $('#FinalDecisionContainer input[type="checkbox"]').each(function (index, el) {
            var elValue =  $(el).val();
            $(el).prop("checked", elValue == maxselected);
            var checked = elValue < maxselected && ((hasTbMeeting == "True" || hasTbMeeting == "true") || elValue > 1);
            $("#Endorsement_" + elValue).prop("checked", checked);
        });
    }

    if (maxselected >= 2 && maxselected < 5 && (hasDirector == "true" || hasDirector == "True")) {
        $(".DirectorContainer").show()
    }
    else {
        $(".DirectorContainer").hide()
    }

}

function clearSearchData() {
    var searchData = {};

    $('.js-submission-search-option').val(1);
    $('.js-submission-search').val("");
    $('#selectedMeetingType').val("");
    $(".js-selected-user-group").data('selected-group-id', '');

    $('.filter-container select').val(undefined);
    $('.filter-container input').val(null);
    $('.table-responsive[sorting-order="Ascending"]').removeAttr('sorting-column-name')
    $('.table-responsive[sorting-order="Descending"]').removeAttr('sorting-column-name')
    $('#userSearch').val("");
    return searchData;
}

function setSearchSorting(grid, sortingColumnName, sortingOrder) {

    $('#' + grid).attr('sorting-column-name', sortingColumnName);
    $('#' + grid).attr('sorting-order', sortingOrder);
}

function formHasUnsavedData() {
    var hasUnsavedData = false;
    $.each(document.forms, function (key, form) {
        var $form = $(form);
        var initState = $form.data('form-init-state');
        if (initState) {
            var currentState = $form.serialize();

            //remove redirect, clarificationGrid and biddersGrid from current state
            var currentStateRemovedIgnoreIds = cleanStateFromIgnoredElements(currentState);
            //on IE init state has clarification and biddersGrid elements (submission form), but on chrome it doesnt
            var initStateRemovedIgnoreIds = cleanStateFromIgnoredElements(initState);
            if (currentStateRemovedIgnoreIds != initStateRemovedIgnoreIds) {
                hasUnsavedData = true;
                return false;
            }
        }
    })
    return hasUnsavedData;
};

function cleanStateFromIgnoredElements(element) {
    var stateRemovedIgnoredIds = '';
    var elements = element.split("&");
    for (i = 0; i < elements.length; i++) {
        var subelements = elements[i].split('=');
        if (subelements[0] == '__RequestVerificationToken' || subelements[0] == 'SummarySelectedSubmissionSubTypes') {

        } else if (elements[i].indexOf('clarificationGrid') === -1 && elements[i].indexOf('Redirect') === -1 && elements[i].indexOf('biddersGrid') === -1) {
            if (stateRemovedIgnoredIds != '') {
                stateRemovedIgnoredIds += "&";
            }
            stateRemovedIgnoredIds += elements[i];
        }
    }
    return stateRemovedIgnoredIds
}

(function () {
    var beforeUnloadHandler = function (e) {
        if (formHasUnsavedData()) {
            confirmLeaving(e);
        }
    }

    var confirmLeaving = function (e) {
        var confirmationMessage = "You have unsaved changes.";
        (e || window.event).returnValue = confirmationMessage; //Gecko + IE
        return confirmationMessage; //Webkit, Safari, Chrome
    }

    window.addEventListener('beforeunload', beforeUnloadHandler, true);
})();

function openModalWindow(title, message, onCloseCallback) {
    $('#commonModalTitle').text(title);
    $('#commonModalMessage').text(message);
   
    if (onCloseCallback && typeof onCloseCallback === 'function') {
        $('#commonModalWindow').on('hidden.bs.modal', function () {
            onCloseCallback();
        })
    }

    $('#commonModalWindow').modal('show');
}

function closeModalWindow() {
    $('#commonModalWindow').modal('hide');
}


function confirmDialog(message, onConfirm, btnColor, borderColor) {
    $("#confirmMessage").empty().append(message + ' Click Yes to continue or No to return.');
    if (btnColor != null) {
        $("#confirmModal #confirmOk").attr("class", btnColor);
    }
    else {
        $("#confirmModal #confirmOk").attr("class", "btn btn-primary");
    }
    if (borderColor != null) {
        $("#confirmationHeader").attr("style", "border-left-color:rgb(217,83,79) !important");
    }
    else {
        $("#confirmationHeader").attr("style", "border-left-color:rgb(111, 197, 235)");
    }

    $("#confirmOk").one("click",
            function() {
                if (onConfirm) {
                    onConfirm();
                };
                $("#confirmModal").modal('hide');;
            });
    $("#confirmCancel").one("click",
        function() {
            $("#confirmModal").modal('hide');;
        });

    $("#confirmModal").modal('show');;
}

var original_header_position = 0;
$(window).scroll(function () {
    setStickyElements();
});

function setStickyElements() {
    if ($('.sticky-header').offset()) {
        if (original_header_position == 0) {
            original_header_position = $('.sticky-header').offset().top
        }

        if ($(this).scrollTop() > original_header_position) {
            //scroll fix
            if ($(document).height() - $(this).scrollTop() - $(window).height() > 80) {
                $('.sticky-header').addClass("sticky");
                $('.sticky-bottom').show()
            }
        }
        else {
            $('.sticky-header').removeClass("sticky");
            original_header_position = 0
            $('.sticky-bottom').hide()
        }
    }
}

function setPopover(popoverOver, popoverContent, popoverTitle) {
    popoverOver.popover({
        html: true,
        content: function () {
            return popoverContent;
        },
        title: function () {
            return popoverTitle;
        },
        placement: function (context, source) {
            var offset = $(source).offset();
            var w = $(window);
            var y = (offset.top - w.scrollTop());
            if (y > 300) {
                return "top";
            }
            return "bottom";
        }
    });
}
$(document).ajaxComplete(function (event, xhr, settings) {
    var responseHeaderNotAuth = xhr.getResponseHeader('X-Responded-JSON');
    if (responseHeaderNotAuth != null) {
        var responseHeaderNotAuthJSON = jQuery.parseJSON(responseHeaderNotAuth);
        if (responseHeaderNotAuthJSON.status == 401) {
            window.location = '/Account/Logout';
        }
    }
    //if (xhr.status == 500) {
    //    window.location = '/Account/Logout';
    //}
    //if (settings.method == "GET" && xhr.responseText == "") {
    //    window.location = '/Account/Logout';
    //}
    //if (settings.url === "ajax/test.html") {
    //    $(".log").text("Triggered ajaxComplete handler. The result is " +
    //      xhr.responseText);
    //}
});