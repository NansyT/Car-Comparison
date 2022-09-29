//document.addEventListener("DOMContentLoaded", function () {
//    SortDropDowns()
//});

var dds = document.querySelectorAll(".dropdown-item");

for (var i = 0; i < dds.length; i++) {
    dds[i].addEventListener('click', function (event) {
        UpdateFilter(event.currentTarget.id)
    })
}

//var btnBrands = document.getElementsByName("btnBrand");

//for (var i = 0; i < btnBrands.length; i++) {
//    btnBrands[i].addEventListener('click', function (event) {

//    })
//}



//function SortDropDowns() {
//    let $ddV = $("ddVariant");
//    var alphabeticallyOrderedDivs = $ddV.sort(function (a, b) {
//        return $(a).find("button").val() > $(b).find("button").val();
//    });
//    $("#ddVariant").html(alphabeticallyOrderedDivs);
//}


function UpdateFilter(newFilter) {
    let id = newFilter.split(" ")[1]

    if (newFilter.includes("Model")) {
        var modelF = document.getElementById(newFilter).innerHTML.trim()
        //alert(modelF);
    }
    else if (newFilter.includes("Brand")) {
        var brandF = document.getElementById(newFilter).innerHTML.trim()
        //alert(modelB);
    }
    else if (newFilter.includes("Variant")) {
        var variantF = document.getElementById(newFilter).innerHTML.trim()
        //alert(modelV);
    }
    else if (newFilter.includes("Year")) {
        var dateF = document.getElementById(newFilter).innerHTML.trim()
        //alert(modelY);
    }

    let ur = 'https://localhost:44355'
    $.ajax({
        url: ur,
        type: 'GET',
        dataType: 'json',
        data: {
            "modelFilter": modelF,
            "brandFilter": brandF,
            "variantFilter": variantF,
            "dateFilter": dateF
        },
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            if (error) {
                console.log(error);
            }
        }
    });
    //.done(function () {
    //    document.getElementById("buttonSubmit").submit();
    //});
}