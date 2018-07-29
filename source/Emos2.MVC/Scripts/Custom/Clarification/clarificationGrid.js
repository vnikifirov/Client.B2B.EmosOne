(function (ClarificationGrid) {
    if (ClarificationGrid === 'undefined' || !ClarificationGrid) {
        ClarificationGrid = {};
    }

    ClarificationGrid.location = {
        param: ''
    };

    ClarificationGrid.selectors = {
        triggerClass: '',
        dataId: '',
        dataLocation: ''
    };

    ClarificationGrid.events = {
        OnClick: function (e) {
            $(ClarificationGrid.selectors.triggerClass).on('click', function () {
                let location = $(this).data(ClarificationGrid.selectors.dataLocation);
                let id = $(this).data(ClarificationGrid.selectors.dataId);
                window.location.href = location + "?" + ClarificationGrid.location.param + "=" + id;
            });
        }
    };

    ClarificationGrid.methods = {
        Init: function (settings) {
            ClarificationGrid.location.param = settings.param;
            ClarificationGrid.selectors.triggerClass = settings.triggerClass;
            ClarificationGrid.selectors.dataId = settings.dataId;
            ClarificationGrid.selectors.dataLocation = settings.dataLocation;
        }
    };

    $.fn.ClarificationGrid = function (settings) {
        ClarificationGrid.methods.Init(settings);
        ClarificationGrid.events.OnClick();
    };

}(window.ClarificationGrid = window.ClarificationGrid || {}));