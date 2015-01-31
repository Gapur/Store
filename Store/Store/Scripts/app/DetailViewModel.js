$(document).ready(function () {
    $('#back').bind('click', function () {
        $('.detail-info').addClass('fadeOutRight');
        setTimeout(function () {
            $('.category-list').removeClass('passive');
            $('.detail-info').remove();
        }, 700);
    });
});