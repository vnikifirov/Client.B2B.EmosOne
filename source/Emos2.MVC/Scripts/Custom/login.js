$(document).ready(function () {
    var inProgress = false;
    $("form").submit(function () {
        if (inProgress) return false;
        inProgress = true;
        showLoader();
    });

    var error_message = $("#ErrorMessage").val();
    if (error_message != "" && error_message != undefined) {
        showMessage({
            IsSuccess: false,
            Message: jQuery.parseJSON(error_message).error_description
        })
    }
})