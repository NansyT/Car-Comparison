$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});


function selectBrand(button) {
    let val = button.innerHTML;

    let ur = 'https://localhost:44355/Home/SelectBrand?brand=' + val.trim();
    sendPOST(ur);
}

function selectModels(button) {
    let val = button.innerHTML;

    let ur = 'https://localhost:44355/Home/SelectModel?model=' + val.trim();
    sendPOST(ur);
}

function selectVariant(button) {
    let val = button.innerHTML;

    let ur = 'https://localhost:44355/Home/SelectVariant?variant=' + val.trim();
    sendPOST(ur);
}

function selectYear(button) {
    let val = button.innerHTML;

    let ur = 'https://localhost:44355/Home/SelectYear?year=' + val.trim();
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