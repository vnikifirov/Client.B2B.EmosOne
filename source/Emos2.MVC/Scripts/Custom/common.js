String.prototype.replaceAll = function (search, replacement) {
    let target = this;
    return target.replace(new RegExp(search, 'g'), replacement);
};


function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    let regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

function redirectTo(location) {
    showLoader();
    window.location.href = location;
}

$(function () {
    $.fn.modal.Constructor.DEFAULTS.backdrop = 'static';
    $.fn.modal.Constructor.DEFAULTS.keyboard = false;
});

//client-side frame busting JavaScript as a protection against XFS

if (top.location != location) {
    top.location.href = document.location.href;
}

if (parent.location != self.location) {
    parent.location = self.location;
}

if (self != top) {
    top.location = self.location;
}