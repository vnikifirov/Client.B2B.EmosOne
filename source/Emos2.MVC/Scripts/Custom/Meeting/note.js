(function (Note) {
    if (Note === 'undefined' || !Note) {
        Note = {};
    }

    Note.url = {
        url: ''
    };

    Note.note = {
        UserId: '',
        SubmissionId: '',
        Note: '',
        MeetingId: ''
    }

    Note.selectors = {
        triggerClass: '',
        dataContainerClass: '',
        noteId: '',
        targetId: '',
        dataMeetingId: '',
        dataUserId: '',
        dataSubmissionId: ''
    };

    Note.events = {
        OnClick: function (e) {
            $(Note.selectors.triggerClass).on('click', function () {
                
                Note.note.UserId = $(Note.selectors.dataContainerClass).data(Note.selectors.dataUserId);
                Note.note.SubmissionId = $(Note.selectors.dataContainerClass).data(Note.selectors.dataSubmissionId);
                Note.note.Note = $(Note.selectors.dataContainerClass).find(Note.selectors.noteId).val();
                Note.note.MeetingId = $(Note.selectors.dataContainerClass).data(Note.selectors.dataMeetingId);
                
                Note.ajax.SaveNote();
            });
        }
    };

    Note.methods = {
        Init: function (settings) {
            Note.url.url = settings.url;
            Note.selectors.triggerClass = settings.triggerClass;
            Note.selectors.dataMeetingId = settings.dataMeetingId;
            Note.selectors.dataUserId = settings.dataUserId;
            Note.selectors.dataSubmissionId = settings.dataSubmissionId;
            Note.selectors.noteId = settings.noteId;
            Note.selectors.dataContainerClass = settings.dataContainerClass;
            Note.selectors.targetId = settings.targetId;
        }
    };

    Note.ajax = {
        SaveNote: function () {
            showLoader();
            
            $.ajax({
                url: Note.url.url,
                type: 'POST',
                headers: { "__RequestVerificationToken": getAntiForgeryToken() },
                data: JSON.stringify({ "model": Note.note }),
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    showMessage(data)
                    //$(Note.selectors.targetId).html(data);
                }
            }).always(function () {
                hideLoader();
            });
        }
    };

    $.fn.Note = function (settings) {
        Note.methods.Init(settings);
        Note.events.OnClick();
    };

}(window.Note = window.Note || {}));