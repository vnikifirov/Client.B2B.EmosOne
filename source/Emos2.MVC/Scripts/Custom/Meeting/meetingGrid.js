(function (MeetingGrid) {
    if (MeetingGrid === 'undefined' || !MeetingGrid) {
        MeetingGrid = {};
    }

    MeetingGrid.location = {
        param: ''
    };

    MeetingGrid.selectors = {
        triggerClass: '',
        dataId: '',
        dataLocation: ''
    };

    MeetingGrid.events = {
        OnClick: function (e) {
            $(MeetingGrid.selectors.triggerClass).on('click', function () {
                let location = $(this).data(MeetingGrid.selectors.dataLocation);
                let id = $(this).data(MeetingGrid.selectors.dataId);
                window.location.href = location + "?" + MeetingGrid.location.param + "=" + id;
            });
        }
    };

    MeetingGrid.methods = {
        Init: function (settings) {
            MeetingGrid.location.param = settings.param;
            MeetingGrid.selectors.triggerClass = settings.triggerClass;
            MeetingGrid.selectors.dataId = settings.dataId;
            MeetingGrid.selectors.dataLocation = settings.dataLocation;
        }
    };

    $.fn.MeetingGrid = function (settings) {
        MeetingGrid.methods.Init(settings);
        MeetingGrid.events.OnClick();
    };

}(window.MeetingGrid = window.MeetingGrid || {}));