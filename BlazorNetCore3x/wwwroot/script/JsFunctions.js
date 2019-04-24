window.JsFunctions = {
    alertifyNotificationSuccess: function (text) {
        var notification = alertify.notify(text, 'success', 3);
    },
    alertifyNotificationError: function (text) {
        var notification = alertify.notify(text, 'error', 3);
    },
    alertifyConfirmGameOver: function (text) {
        alertify.defaults.ok = "btn btn-primary";
        var notification = alertify.alert('Game Over', 'You scored ' + text + ' out of 25');
    }
};
