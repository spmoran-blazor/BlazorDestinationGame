window.JsFunctions = {
    alertifyNotificationSuccess: function (text) {
        var notification = alertify.notify(text, 'success', 3);
    },
    alertifyNotificationError: function (text) {
        var notification = alertify.notify(text, 'error', 3);
    },
    alertifyConfirmGameOver: function (text) {
        alertify.defaults.transition = "slide";
        alertify.defaults.theme.ok = "btn btn-outline-primary w-25";
        var notification = alertify.alert('Game Over',text);
    }
};
