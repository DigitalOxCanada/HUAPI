
function changeGoLive() {
    PNotify.prototype.options.styling = "fontawesome";

//    alert($('#cbIsLive').is(':checked')); //this will be what the new setting is before visually seeing it happen
    var isLive = $('#cbIsLive').is(':checked');
    $.ajax({
        url: '/api/v1/system/setting',
        method: 'post',
        contentType: 'application/json',
        dataType: 'json',
        success: function (data, status) {

            //PNotify.desktop.permission(); //if desktop: true
            if (isLive) {
                new PNotify({
                    title: 'System is: LIVE',
                    text: 'The system is now online and any available SMS messages will be sent.',
                    type: 'success',
                    icon: true,
                    animation: 'fade',
                    shadow: true,
                    desktop: {
                        desktop: false
                    }
                });
            } else {
                new PNotify({
                    title: 'System is: NOT LIVE',
                    text: 'The system is not live and any available SMS message will not be sent.',
                    type: 'warn',
                    icon: true,
                    animation: 'fade',
                    shadow: true,
                    desktop: {
                        desktop: false
                    }
                });

            }
        },
        error: function (c) {
            new PNotify({
                title: 'changeGoLive() Error',
                text: JSON.stringify(c),
                type: 'error',
                icon: true,
                width: 1000
            });
        },
        data: JSON.stringify({ Setting: "IsLive", Value: $('#cbIsLive').is(':checked') })
    });
}
