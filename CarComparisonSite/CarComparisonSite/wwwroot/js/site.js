$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

let currentURL = window.location.href;

function selectBrand(button) {
    let val = button.innerHTML;

    let ur = currentURL + 'Home/SelectBrand?brand=' + val.trim();
    sendPOST(ur);
}

function selectModels(button) {
    let val = button.innerHTML;

    let ur = currentURL + 'Home/SelectModel?model=' + val.trim();
    sendPOST(ur);
}

function selectVariant(button) {
    let val = button.innerHTML;

    let ur = currentURL + 'Home/SelectVariant?variant=' + val.trim();
    sendPOST(ur);
}

function selectYear(button) {
    let val = button.innerHTML;

    let ur = currentURL + 'Home/SelectYear?year=' + val.trim();
    sendPOST(ur);
    
}

function sendPOST(ur) {
    $.ajax({
        url: ur,
        type: 'POST',
        success: function () {
            location.reload();
        },
        error: function (error) {
            if (error) {
                console.log(error);
            }
        }
    });
}