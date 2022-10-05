// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});


function selectBrand(button) {
    let val = button.innerHTML;
    console.log(val)

    let ur = 'https://localhost:44355/Home/SelectBrand?brand=' + val;
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

function selectModels(button) {
    let val = button.innerHTML;
    console.log(val)

    let ur = 'https://localhost:44355/Home/SelectModel?model=' + val.trim();
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

function selectVariant(button) {
    let val = button.innerHTML;
    console.log(val)

    let ur = 'https://localhost:44355/Home/SelectVariant?variant=' + val.trim();
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

function selectYear(button) {
    let val = button.innerHTML;
    console.log(val)

    let ur = 'https://localhost:44355/Home/SelectYear?year=' + val.trim();
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