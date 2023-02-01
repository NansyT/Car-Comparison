var select = document.getElementById('kmYear');


for (var i = 0; i < 50001; i += 2500) {
    var opt = document.createElement('option');
    opt.value = i;
    opt.innerHTML = i;
    select.appendChild(opt);
}

function setKm() {
    if (document.getElementById('kmHolder').innerHTML === undefined) {
        select.value = 0;
    }
    else {
        select.value = document.getElementById('kmHolder').innerHTML;
    }
}