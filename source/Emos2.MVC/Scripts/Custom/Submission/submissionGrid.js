(function (SubmissionGrid) {
    if (SubmissionGrid === 'undefined' || !SubmissionGrid) {
        SubmissionGrid = {};
    }

    SubmissionGrid.location = {
        param: ''
    };

    SubmissionGrid.selectors = {
        triggerClass: '',
        dataId: '',
        dataLocation: ''
    };

    SubmissionGrid.events = {
        OnClick: function (e) {
            $(SubmissionGrid.selectors.triggerClass).on('click', function () {                
                let location = $(this).data(SubmissionGrid.selectors.dataLocation);
                let id = $(this).data(SubmissionGrid.selectors.dataId);
                window.location.href = location + "?" + SubmissionGrid.location.param + "=" + id;
            });
        }
    };

    SubmissionGrid.methods = {
        Init: function (settings) {
            SubmissionGrid.location.param = settings.param;
            SubmissionGrid.selectors.triggerClass = settings.triggerClass;
            SubmissionGrid.selectors.dataId = settings.dataId;
            SubmissionGrid.selectors.dataLocation = settings.dataLocation;
        }
    };

    $.fn.SubmissionGrid = function (settings) {
        SubmissionGrid.methods.Init(settings);
        SubmissionGrid.events.OnClick();
    };

}(window.SubmissionGrid = window.SubmissionGrid || {}));