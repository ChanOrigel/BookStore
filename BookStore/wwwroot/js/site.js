// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


//////////////////////////////////////////////////////////
///VALIDATE/////////////////
//////////////////////////////////////////////////////////
function ValidateData() {
    var passed = true;

    if (!Validate($('#Title').val(), "TitleDiv")) {
        passed = false;
    }
    if (!Validate($('#Author').val(), "AuthorDiv")) {
        passed = false;
    }

    if (passed) {
        $('#FormBook').submit();
    }
}


function Validate(el = null, id) {
    var res = true;
    if (el == null || el == "") {
        $('#' + id).children('label').addClass("error");
        $('#' + id).children('span.error').show();
        res = false;
    } else {
        $('#' + id).children('label').removeClass("error");
        $('#' + id).children('span.error').hide();
        res = true;
    }
    return res;
}



window.onscroll = function () {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        $('.Go-up').show();
    } else {
        $('.Go-up').hide();
    }

};

$("a[href='#top']").click(function () {
    $("html, body").animate({ scrollTop: 0 }, "slow");
    return false;
});