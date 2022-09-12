$('.button').click(function () {
    $.blockUI({
        css: {
            border: 'none',
            padding: '55px',
            backgroundColor: 'rgba(6, 73, 181,0.0)',
            opacity: 1.0
        },
        overlayCSS: {
            cursor: 'wait',

        },
        message: '<div class="loader">Loading......</div>'
    });
});