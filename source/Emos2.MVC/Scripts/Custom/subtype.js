(function (SubType) {
    if (SubType === 'undefined' || !SubType) {
        SubType = {};
    }

    SubType.selectors = {
        triggerID: '',
        subTypeID: '',
        name: ''
    };

    SubType.events = {
        Change: function (e) {
            $(SubType.selectors.triggerID).on('click', function (e) {
                SubType.methods.SetSubType(e);
            });
        }
    };

    SubType.methods = {
        Init: function (settings) {            
            SubType.selectors.subTypeID = settings.subTypeID;
            SubType.selectors.triggerID = settings.triggerID;
            SubType.selectors.name = settings.name;
        },
        SetSubType: function (e) {
            let value = $(SubType.selectors.triggerID)
                            .find("input[name='" + SubType.selectors.name + "']:checked")
                        .parent()
                            .find('label')
                            .text();
            if (!value) {
               value = $(SubType.selectors.triggerID)
                            .find("input[name='" + SubType.selectors.name + "']:checked")
                        .closest('label')
                            .text();
            }

            if (value) {
                $(SubType.selectors.subTypeID)
                    .val(value.replace(/^\s+|\s+$/g,''))
                        .change();
            }
        }
    };

    $.fn.SubType = function (settings) {
        SubType.methods.Init(settings);
        SubType.events.Change();
    };

}(window.SubType = window.SubType || {}));