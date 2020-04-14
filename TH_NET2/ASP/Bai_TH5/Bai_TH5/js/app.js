function toggle_menu() {
    var menu = $('#menu');
    var content =  $('#content');
    if (menu.hasClass('d-none') == true) {
        menu.removeClass('d-none');
        menu.removeClass('bounceOutLeft');
        menu.addClass('bounceInLeft');
        menu.addClass('d-block');

        content.removeClass('col-12');
        content.addClass('col-10');
    }
    else {
        menu.removeClass('d-block');
        menu.removeClass('bounceInLeft');
        menu.addClass('bounceOutLeft');
        menu.addClass('d-none');

        content.removeClass('col-10');
        content.addClass('col-12');
    }
}

function replaceDiemDA(number) {
    location.replace('frm_danhsachdiemda.aspx?loai=' + number);
}