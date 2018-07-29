function userCreatedSuccess(data) {

    if (data.IsSuccess) {

        show(data.Message);

        $('#containerCreateUser').hide();

        fillUserUpdateContainer(data.Model);

        $('#containerUpdateUser').show();
    }
    else {
        showMessage(data);
    }
}

function fillUserUpdateContainer(userData) {
    $('#containerUpdateUser').find("input[id='Username']").val(userData.Username);
    $('#containerUpdateUser').find("input[id='FirstName']").val(userData.FirstName);
    $('#containerUpdateUser').find("input[id='LastName']").val(userData.LastName);
    $('#containerUpdateUser').find("input[id='MiddleName']").val(userData.MiddleName);
    $('#containerUpdateUser').find("input[id='Designation']").val(userData.Designation);
    $('#containerUpdateUser').find("input[id='Email']").val(userData.Email);
    $('#containerUpdateUser').find("input[id='MobilePhone']").val(userData.MobilePhone);
    $('#containerUpdateUser').find("input[id='WorkPhone']").val(userData.WorkPhone);
}

function userUpdateSuccess(data) {

    if (data.IsSuccess) {

        // alert(data.Message);
        showMessage(data);

        finishEdit();
        refreshUsersGrid();
    }
    else {

        // alert(data.Message);
        showMessage(data);
    }
}

function finishEdit() {
    $('#containerUpdateUser').hide()
    resetUserContainers();
}

function resetUserContainers() {
    $('#containerCreateUser').find("input[id='Username']").val('');
    $('#containerCreateUser').find("input[id='Password']").val('');
    $('#containerCreateUser').find("input[id='PasswordConfirmation']").val('');

    $('#containerUpdateUser').find("input[id='Username']").val('');
    $('#containerUpdateUser').find("input[id='FirstName']").val('');
    $('#containerUpdateUser').find("input[id='LastName']").val('');
    $('#containerUpdateUser').find("input[id='MiddleName']").val('');
    $('#containerUpdateUser').find("input[id='Designation']").val('');
    $('#containerUpdateUser').find("input[id='Email']").val('');
    $('#containerUpdateUser').find("input[id='MobilePhone']").val('');
    $('#containerUpdateUser').find("input[id='WorkPhone']").val('');
    $('#containerUpdateUser').find("input[id='Photo']").val('');
}

function editUser(username) {
    $.ajax({

        url: '/User/EditUser',
        type: 'POST',
        data: '{ username: "' + username + '" }',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            $('#containerUpdateUser').show();
            $('#containerCreateUser').hide();
            $('html, body').animate({
                scrollTop: $("#containerUpdateUser").offset().top
            }, 1000);
            fillUserUpdateContainer(data.Model);
        }
    });
}

function deleteUser(event,accountId) {
    event.stopPropagation();
    confirmDialog('Are you sure you want to delete selected record?', _deleteUserOkBtnClick);
    function _deleteUserOkBtnClick() {
        $.ajax({

            url: '/User/DeleteUser',
            type: 'POST',
            data: '{ accountId: "' + accountId + '" }',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                showMessage(data);
                refreshUsersGrid();
            }
        });
    }

}

function userSaveSuccess(data) {

    showMessage(data.responseModel);
    if (data.responseModel.IsSuccess) {
        $('#userCreateModal').modal('hide');
        refreshUsersGrid();
    } else {
        showMessage(data.responseModel);
    }
}

function openUser(accountDataId) {
    showLoader();
    $.ajax({
        method: "GET",
        url: "/User/OpenUser",
        data: { accountDataId: accountDataId },
        cache: false
    }).success(function (data) {
        $('#userCreateContent').html(data);
        $('#userCreateModal').modal('show');
        $('#userCreateModal').on('hidden.bs.modal', function () {
            $('#userCreateContent').html('');
        });
        $('#bootstrapMultiselectRoles').multiselect();
        $('#bootstrapMultiselectMainRoles').multiselect();
        
        //Main User
        var currentMainUser = $("#CurrentMainUserForRole").val();
        if (currentMainUser) {
            $("#User_MainUserForRole").val(currentMainUser).attr("selected", "selected");
        }
        //Delegate
        var delegateUserId = $("#CurrentDelegateUserId").val();
        if (delegateUserId) {
            $("#User_DelegateUserId").val(delegateUserId).attr("selected", "selected");
        }

        setCreateUserFormState();

    }).always(function () {
        hideLoader();
    });
}

function profileSaveSuccess(data) {

    showMessage(data.responseModel);
    if (data.responseModel.IsSuccess) {
        $('#profileCreateModal').modal('hide');
        //refreshUsersGrid();
        refreshUsersProfilesGrid();
    } else {
        showMessage(data.responseModel);
    }
}

function openProfile(accountDataId) {
    showLoader();
    $.ajax({
        method: "GET",
        url: "/User/OpenProfile",
        data: { accountDataId: accountDataId },
        cache: false
    }).success(function (data) {
        $('#profileCreateContent').html(data);
        $('#profileCreateModal').modal('show');
        $('#profileCreateModal').on('hidden.bs.modal', function () {
            $('#profileCreateContent').html('');
        });
        $('#bootstrapMultiselectRoles').multiselect();
        $('#bootstrapMultiselectMainRoles').multiselect();
        /*
        //Main User
        var currentMainUser = $("#CurrentMainUserForRole").val();
        if (currentMainUser) {
            $("#User_MainUserForRole").val(currentMainUser).attr("selected", "selected");
        }
        //Delegate
        var delegateUserId = $("#CurrentDelegateUserId").val();
        if (delegateUserId) {
            $("#User_DelegateUserId").val(delegateUserId).attr("selected", "selected");
        }
        */
        setCreateProfileFormState();
       

    }).always(function () {
        hideLoader();
    });
}


function refreshUsersProfilesGrid() {

    var gridState = getGridState('userProfileGridContainer');
    var userid = $("#userProfileGridContainer").attr("parententityid");

    if (!gridState.FilterState.isValid) return false;

    showLoader();

    var searchData = getSearchData();


    $.ajax({
        method: "GET",
        url: "/User/GetUserProfileGrid",
        data: { "gridStateModel": gridState, "searchData": searchData, "userId": userid },
        cache: false
    }).success((data) => {
        $('#userProfileGridContainer').html(data);
    }).error((data) => { }).always(() => {
        hideLoader();
        });;

}




function setCreateProfileFormState() {
    var $form = $('#createProfileForm');
    $form.data('form-init-state', $form.serialize());
}

function setCreateUserFormState() {
    var $form = $('#createUserForm');
    $form.data('form-init-state', $form.serialize());
}

function getUserSearchData() {
    var searchData = {};

    searchData.Roles = $(".js-selected-user-group").data('selected-group-id');
    searchData.SearchCriteria = $('#userSearch').val();

    return searchData;
}

function selectUserGroup(type_id) {
    $(".js-selected-user-group").data('selected-group-id', type_id);
    filterGrid('refreshUsersGrid');
}

function refreshUsersGrid() {
    var gridState = getGridState('userGridContainer');
    
    if (!gridState.FilterState.isValid) return false;

    showLoader();
 
    var searchData = getUserSearchData();
    var url = "/User/UsersGrid";

    $.ajax({
        url: url,
        method: "POST",
        cache: false,
        data: JSON.stringify({ "gridStateModel": gridState, "searchData": searchData }),
        contentType: 'application/json; charset=utf-8'
    }).success(function (data) {
        $('#userGridContainer').html(data);
    }).always(function () { hideLoader(); });
}


function verfyUser() {

    showLoader();
    var email = $('#txtEmail').val();
   
    $.ajax({
        method: 'GET',
        url: '/User/VerifyUser',
        data: { email: email },
        success: function (data) {
            
            showMessage(data);

            if (data.IsSuccess) {
        
             
                $('#txtUsername').val(data.Model.Username);
                $('#txtFirstName').val(data.Model.FirstName);
                $('#txtLastName').val(data.Model.LastName);
                $('#txtEmail').val(data.Model.Email);

                $('#txtDesignation').val(data.Model.Designation);
                $('#txtMobilePhone').val(data.Model.MobilePhone);

                $('#ddDepartmentId').val(data.Model.DepartmentId);

                //$('#txtPassword').val(data.Model.Password);
                //$('#txtPasswordConfirmation').val(data.Model.Password);
               
                if (data.Model.PhotoBase64 != null) {
                    $("#UserPhoto").attr('src', 'data:image/png;base64,' + data.Model.PhotoBase64);
                    $("#User_PhotoBase64").val(data.Model.PhotoBase64);
                }
                else {
                    $("#UserPhoto").attr('src', '../img/no-image.png');
                    $("#User_PhotoBase64").val("");
                } 

            }
            else {
                //not found
                 
                $('#subtitleMessage').val('User not found. Please try again.');
            
                $('#txtUsername').val('');
                $('#txtFirstName').val('');
                $('#txtLastName').val('');
                $('#txtMiddleName').val('');

                $('#txtEmail').val('');

                $('#txtDesignation').val('');
                $('#txtMobilePhone').val('');
                $('#txtWorkPhone').val('');

                $("#UserPhoto").attr('src', '../img/no-image.png');
                $("#User_PhotoBase64").val("");
            }

        }
    }).always(function () { hideLoader(); });
}




function onFileChange(files) {
    if (files.length === 0) return;
    if (typeof FileReader === "undefined") return;

    if (/image/.test(files[0].type)) {
        var img = document.getElementById("UserPhoto");
        var reader = new FileReader();
        reader.onload = function (e) {
            img.src = e.target.result;
        }
        reader.readAsDataURL(files[0])
    }
}


(function ($) {
    $.fn.serializefiles = function () {
        var obj = $(this);
        /* ADD FILE TO PARAM AJAX */
        var formData = new FormData();
        $.each($(obj).find("input[type='file']"), function (i, tag) {
            $.each($(tag)[0].files, function (i, file) {
                formData.append(tag.name, file);
            });
        });
        var params = $(obj).serializeArray();
        $.each(params, function (i, val) {
            formData.append(val.name, val.value);
        });
        return formData;
    };
})(jQuery);


function saveUserPressed() {
    showLoader();
    var data = $("#createUserForm").serializefiles();
    jQuery.ajax({
        url: '/User/SaveUser',
        data: data,
        cache: false,
        contentType: false,
        processData: false,
        method: 'POST',
        type: 'multipart/form-data', // For jQuery < 1.9
        success: function (data) {
            userSaveSuccess(data);
            hideLoader();
        }
    });
}

function saveProfilePressed() {
    showLoader();
    var data = $("#createProfileForm").serializefiles();
    jQuery.ajax({
        url: '/User/SaveUserProfile',  
        data: data,
        cache: false,
        contentType: false,
        processData: false,
        method: 'POST',
        type: 'multipart/form-data', // For jQuery < 1.9
        success: function (data) {
            profileSaveSuccess(data);
            hideLoader();
        }
    });
}


function deactivateUserProfile(userProfileID)
{

    $.ajax({
        method: "POST",
        url: "/User/DeactivateProfile",
        data: { "userProfileID": userProfileID },
        cache: false
    }).success((data) => {
        refreshUsersProfilesGrid();
        showMessage(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;

}


function activateUserProfile(userProfileID) {

    $.ajax({
        method: "POST",
        url: "/User/ActivateProfile",
        data: { "userProfileID": userProfileID },
        cache: false
    }).success((data) => {
        refreshUsersProfilesGrid();
        showMessage(data);
    }).error((data) => { }).always(() => {
        hideLoader();
    });;

}



