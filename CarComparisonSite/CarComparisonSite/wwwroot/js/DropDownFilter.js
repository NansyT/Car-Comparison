//document.addEventListener("DOMContentLoaded", function () {
//    SortDropDowns()
//});

var dds = document.querySelectorAll(".dropdown-item");

for (var i = 0; i < dds.length; i++) {
    dds[i].addEventListener('click', function (event) {
        UpdateFilter(event.currentTarget.id)
    })
}



//function SortDropDowns() {
//    let $ddV = $("ddVariant");
//    var alphabeticallyOrderedDivs = $ddV.sort(function (a, b) {
//        return $(a).find("button").val() > $(b).find("button").val();
//    });
//    $("#ddVariant").html(alphabeticallyOrderedDivs);
//}


function UpdateFilter(newFilter) {
    let id = newFilter.split(" ")[1]
    if (newFilter.includes("model")) {
        alert(id)
    }
    else if (newFilter.includes("brand")) {
        alert(id)
    }
    else if (newFilter.includes("variant")) {
        alert(id)
    }
    else if (newFilter.includes("year")) {
        alert(id)
    }
}