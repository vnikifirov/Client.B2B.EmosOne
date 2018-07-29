(function (Subtype) {
    if (Subtype === 'undefined' || !Subtype) {
        Subtype = {};
    }

    Subtype.selectors = {
        triggerClass: '.js-subtype-select',
        effectClass: '.js-subtype-set-',
        sbutypeListClass: '.js-types-list',
        sutypeSelectClass: '.js-option-',
        dataOption: 'data-option'
    };

    Subtype.type = {
        Local: 4,
        Periodical: 5,
        EndOfService: 6,
        SpecialNeeds: 7,
        MedicalGrounds: 8
    };

    Subtype.events = {
        Change: function (e) {
            $(Subtype.selectors.triggerClass).on('click keyup input paste', function (e) {                
                Subtype.methods.SelectOption();
                Subtype.methods.SetVisible();
            });
        }
    };

    Subtype.methods = {
        SelectOption: function () {            
            let anyBoxesChecked = false;
            $(Subtype.selectors.sbutypeListClass).find('input[type="checkbox"]').each(function () {
                if ($(this).is(":checked")) {
                    anyBoxesChecked = true;
                }
            });

            if (anyBoxesChecked == false) {
                $(Subtype.selectors.sutypeSelectClass + Subtype.type.NoImpact).attr('checked', 'checked');
            }
        },
        SetVisible: function () {
            $(Subtype.selectors.sbutypeListClass).find('input[type="checkbox"]').each(function () {
                let val = $(this).attr(Subtype.selectors.dataOption);
                if ($(this).is(":checked")) {
                    $(Subtype.selectors.effectClass + val).removeClass('hiden');
                    if (val == Subtype.type.PriceChange) {
                        $('#BudgetUSD').prop('readonly', true);
                        $('#BudgetAED').prop('readonly', true);
                        $('#BudgetAED').prop('tabindex', "-1");
                        $('#BudgetUSD').prop('tabindex', "-1");
                        //added delay because sometimes it has weard formating (72,200,200.00-) after delay it is 72,200,200.00
                        setTimeout(
                             function () {
                                 $('#BudgetUSD').val($('#submissionVRModel_DifferenceBudgetUSD').val())
                                 $('#BudgetAED').val($('#submissionVRModel_DifferenceBudgetAED').val())
                             }, 200);

                    }
                }
                else {
                    $(Subtype.selectors.effectClass + val).addClass('hiden');
                    if (val == Subtype.type.PriceChange) {
                        $('#BudgetAED').prop('readonly', false);
                        $('#BudgetUSD').prop('readonly', false);
                        $('#BudgetAED').prop('tabindex', false);
                        $('#BudgetUSD').prop('tabindex', false);
                    }
                }

            });
        }

    };

    $.fn.Subtype = function () {
        Subtype.events.Change();
        Subtype.methods.SetVisible();
    };

}(window.Subtype = window.Subtype || {}));