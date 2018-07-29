function createWorkflow(redirect) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/WorkflowCreate",
        data: { submissionId: 0, "redirect": redirect },
        cache: false
    }).success(function (data) {
        $('#workflowContainer').html('');
        $('#workflowContainer').hide();
        $('#WorkflowCreateContent').html(data);
        $('#WorkflowCreateModal').modal('show');
        $('#WorkflowCreateModal').off('hidden.bs.modal');
        $('#WorkflowCreateModal').on('hidden.bs.modal', function () {
            $('#WorkflowCreateContent').html('');
        });

        setWorkflowCreateFormState();
        
    }).always(function () {
        hideLoader();
    });

}


function setWorkflowCreateFormState() {
    var $form = $('#workflowCreateForm');
    $form.data('form-init-state', $form.serialize());
}

function WorkflowCreateSuccess(data) {

    showMessage(data);

    if (data.IsSuccess) {

        var workflow = JSON.parse(data.Data);

        if (!workflow.Redirect) {
            $('#WorkflowCreateModal').on('hidden.bs.modal', function () {
                $('#WorkflowCreateContent').html('');
                //openWorkFlow(workflow.Id, true);
                refreshWorkflowGrid();
            })
            $('#WorkflowCreateModal').modal('hide');
        }
        else {
            $('#WorkflowCreateModal').modal('hide');
            $('#WorkflowCreateContent').html('');
            //redirectToSubmission('/WorkflowConfigurator/workflows', submission.Id);
        }

        openWorkflow(workflow.WorkflowId, true);

    }
    hideLoader();

}


function refreshWorkflowGrid() {

    var gridState = getGridState('workflowGrid');

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();

    var redirect = $('#Redirect').val();

    $.ajax({
        method: "POST",
        url: "/WorkflowConfigurator/WorkflowGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData, "redirect": redirect }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#workflowGrid').html(data);
        history.replaceState(null, '', location.origin + location.pathname + getSearchParam(searchData));
    }).always(function () {
        hideLoader();
    });
}




function openWorkflow(workflowID, scrollToDetails) {

    history.replaceState(null, "", "/WorkflowConfigurator/Workflows?openworkflow=" + workflowID);
    if (!$('#workflowContainer').length)
        return;

    showLoader()
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/Workflow",
        data: { workflowId: workflowID },
        cache: false
    }).success(function (data) {
        $('#workflowContainer').html(data);
        $('#workflowContainer').show();

        $('#js-submission-grid tr').removeClass('row-select');
        $('#js-submission-grid tr[data-submission-id=' + workflowID + ']').addClass('row-select');

        $('select[readonly] option:not(:selected)').hide();


        if (scrollToDetails) {
            $('html, body').animate({
                scrollTop: $("#workflowContainer").offset().top
            }, 1000);
        }

        setWorkflowSaveFormState();
        if (!data.IsSuccess && data.Message != undefined) {
            self.showErrorMessage(data.Message);
        }
    }).always(function () {
        hideLoader();
    });
}


function setWorkflowSaveFormState() {
    var $form = $('#WorkflowSaveForm');
    $form.data('form-init-state', $form.serialize());
}


function WorkflowSaveSuccess(data) {
    if (routeToSumissionIdAfterSave == 0 || !data.IsSuccess) {
        showMessage(data);
    }

    if (data.IsSuccess) {
        setWorkflowSaveFormState();
        refreshWorkflowGrid();
    }
}




function createWorkflowStep(workflowID) {
    showLoader();
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/WorkflowCreateStep",
        data: { workflowID: workflowID },
        cache: false,
    }).success(function (data) {

        $('#WorkflowStepCreateContent').html(data);
        $('#WorkflowStepCreateModal').modal('show');
        $('#WorkflowStepCreateModal').off('hidden.bs.modal');
        $('#WorkflowStepCreateModal').on('hidden.bs.modal', function () {
            $('#WorkflowStepCreateContent').html('');

            setWorkflowStepSaveFormState();
        })
        }).always(function () {
            hideLoader();
        });
}


function WorkflowStepCreateSuccess(data) {

    showMessage(data);

    var workflowStep = JSON.parse(data.Data);
    var workflowId = workflowStep.WorkflowId;
    if (data.IsSuccess) {

            
            $('#WorkflowStepCreateModal').modal('hide');
            $('#WorkflowStepCreateContent').html('');

            refreshWorkflowStepGrid(workflowId);
          
          
        }
    
    hideLoader();
}






function setWorkflowStepSaveFormState() {
    var $form = $('#workflowStepCreateForm');
    $form.data('form-init-state', $form.serialize());
}




function refreshWorkflowStepGrid(workflowID) {

    var gridState = getGridState('workflowStepGrid');

    if (!workflowID) {
        workflowID = $("#workflowStepGrid").attr("panerentityid");
    }

    if (!gridState.FilterState.isValid) return false;

    showLoader();
    var searchData = getSearchData();


    $.ajax({
        method: "POST",
        url: "/WorkflowConfigurator/WorkflowStepGrid",
        headers: { "__RequestVerificationToken": getAntiForgeryToken() },
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData,  "workflowID": workflowID }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#workflowStepGrid').html(data);
    }).always(function () {
        hideLoader();
    });
}


function openWorkflowStep(workflowStepID) {

    showLoader()
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/WorkFlowStep",
        data: { workflowStepID: workflowStepID },
        cache: false
    }).success(function (data) {
        $('#WorkflowStepCreateContent').html(data);
        $('#WorkflowStepCreateContent').show();

        $('#WorkflowStepCreateModal').modal('show');
        //$('#SubmissionCreateModal').off('hidden.bs.modal');
        //$('#SubmissionCreateModal').on('hidden.bs.modal', function () {
        //    $('#SubmissionCreateContent').html('');
        //});

        if (!data.IsSuccess && data.Message != undefined) {
            self.showErrorMessage(data.Message);
        }
    }).always(function () {
        hideLoader();
        });

}




function deleteWorkflowStep(event, workflowStepID, workflowID) {

    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteWorkflowStepOkBtnClick);

    function _deleteWorkflowStepOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/WorkflowConfigurator/DeleteWorkflowStep",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { workflowStepID: workflowStepID },
            cache: false
        })
            .success((data) => {
                showMessage(data);
                refreshWorkflowStepGrid(workflowID);

            });
    }
}



function openWorkflowStepActions(event,workflowStepID) {
    event.stopPropagation();
    showLoader()
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/WorkflowStepActionGrid",
        data: { workflowStepId: workflowStepID },
        cache: false
    }).success(function (data) {
        $('#WorkflowStepActionGridContent').html(data);
        $('#WorkflowStepActionGridContent').show();

        $('#WorkflowStepActionGridModal').modal('show');
       
        if (!data.IsSuccess && data.Message != undefined) {
            self.showErrorMessage(data.Message);
        }
    }).always(function () {
        hideLoader();
    });
}



function addAction(workflowStepId) {

    showLoader();
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/AddActionWindow",
        data: { workflowStepId: workflowStepId },
        cache: false,
    }).success(function (data) {

        $('#AddActionContent').html(data);
        $('#AddActionModal').modal('show');
        $('#AddActionModal').off('hidden.bs.modal');
        $('#AddActionModal').on('hidden.bs.modal', function () {
            $('#AddActionContent').html('');

            ///setWorkflowStepSaveFormState();
        })
    }).always(function () {
        hideLoader();
    });
}



function ActionCreateSuccess(data) {

    showMessage(data);

    var action = JSON.parse(data.Data);
    var workflowStepId = action.StepId;
    if (data.IsSuccess) {


        $('#AddActionModal').modal('hide');
        $('#AddActionContent').html('');

        refreshActionGrid(workflowStepId);


    }

    hideLoader();
}


function onBeginAjaxPostCreateAction(xhr) {
    onBeginAjaxPost(xhr)
    showLoader()
}

function onBeginAjaxPost(xhr) {
    var token = getAntiForgeryToken();
    xhr.setRequestHeader("__RequestVerificationToken", token);
}



function refreshActionGrid(workflowStepID) {
    showLoader()
    $.ajax({
        method: "GET",
        url: "/WorkflowConfigurator/WorkflowStepActionGrid",
        data: { workflowStepId: workflowStepID },
        cache: false
    }).success(function (data) {
        $('#WorkflowStepActionGridContent').html(data);
        $('#WorkflowStepActionGridContent').show();

        $('#WorkflowStepActionGridModal').modal('show');

        if (!data.IsSuccess && data.Message != undefined) {
            self.showErrorMessage(data.Message);
        }
    }).always(function () {
        hideLoader();
    });
}


function deleteAction(event, stepActionId, workflowStepID) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected action?', _deleteActionOkBtnClick);

    function _deleteActionOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/WorkflowConfigurator/DeleteAction",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { stepActionId: stepActionId, workflowStepID: workflowStepID },
            cache: false
        })
            .success((data) => {
                showMessage(data);
                refreshActionGrid(workflowStepID);

            });
    }
}


function DeleteWorkflow(event, workflowID) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete workflow?', _deleteWorkflowOkBtnClick);

    function _deleteWorkflowOkBtnClick() {
        $.ajax({
            method: "POST",
            url: "/WorkflowConfigurator/DeleteWorkflow",
            headers: { "__RequestVerificationToken": getAntiForgeryToken() },
            data: { workflowID: workflowID },
            cache: false
        })
            .success((data) => {
                showMessage(data);
                refreshWorkflowGrid();
                closeWorkflow(); 

            });
    }
}

function closeWorkflow() {
    $('#containerSaveSubmission').hide();
    $('#containerSaveSubmission').empty();
    history.replaceState(null, "", "/WorkflowConfigurator/Workflows");
}






