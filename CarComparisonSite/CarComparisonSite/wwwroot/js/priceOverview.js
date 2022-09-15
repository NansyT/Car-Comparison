var kmDriven;

// Gas car prices
var newGas;
var fuelUseGas;
var syn;
var serv = 3500;
var fuelP = 17.7325;

// Electric car prices
var newPElec;
var electUseElec;
var sub;
var ref = 1.06;
//Raw electric price
//Notes: Price for kWh/h is not precise.
//We have used the average raw price not including any vat
//or other additional costs that may be applied in real life.
var electP = 2.0225;
//with ab
var startprice;
//Uden ab
var charger;

var ownership;

window.onload = function () {
    document.getElementById("electricRadioRent").checked = true;
    ownership = "Rent";
    document.getElementById("kmYear").addEventListener('change', function (e) {
        calcGas();
        calcElec();
    })
    calcGas();
    calcElec();

    document.getElementById("electricRadioRent").addEventListener('change', function () {
        ownership = "Rent";
        calcGas();
        calcElec();
    })

    document.getElementById("electricRadioOwn").addEventListener('change', function () {
        ownership = "Own";
        calcGas();
        calcElec();
    })

    //Eventlistener for links in nav statistics
    var navlinks = document.querySelectorAll(".nav-link");
    for (var i = 0; i < navlinks.length; i++) {
        navlinks[i].addEventListener('click', e => {
            //Check if user is pressing the same button, as the active one
            //If so, do nothing
            if (!e.currentTarget.classList.contains('active')) {
                let hiddenEl = document.getElementById("currentTab");
                if (!isNaN(e.currentTarget.id[0])) {
                    hiddenEl.innerHTML = e.currentTarget.id[0];
                }
                else {
                    hiddenEl.innerHTML = "all";
                }
                console.log(hiddenEl.innerHTML)
                calcElec();
                calcGas();
            }
        })
    }
}

function calcGas() {
    if (document.getElementById("chosenGasCarBrand") != null) {
        calculateGasCar();
    }
}

function calcElec() {
    if (document.getElementById("chosenElecCarBrand") != null) {
        calculateElecCar();
    }
}

function df() {
    if (document.getElementById("kmYear").value > 0) {
        calculateGasCar();
    }
}

function checkKm() {

}
function calculateFuelPrice() {
        kmDriven = document.getElementById("kmYear").value;
    if (kmDriven != "") {

        fuelUseGas = parseFloat(document.getElementById("useKmGasI").innerHTML.replace(',', "."));
        return (kmDriven / fuelUseGas) * fuelP;
    }
    return 0;
}

function calculateGasCar() {
    newGas = parseFloat(document.getElementById("newPGasI").innerHTML);
    var fuel = parseFloat(calculateFuelPrice());
    var inspection = parseFloat(calculateInspectionPrice());
    var year = document.getElementById("currentTab").innerHTML;
    var total;
    syn = 0;
    if (year == "all") {
        inspection *= 5;
        fuel *= 5;
        syn = 490;
        total = (inspection + syn + fuel)
        total += newGas;
    }
    else {
        total = fuel + inspection;
        if (year == "1") {
            total += newGas;
        }
        else if (year == "4") {
            newGas = 0;
            syn = 490;
            total += syn;
        }
        else {
            newGas = 0;
        }
    }

    document.getElementById("newPGasO").innerHTML = newGas.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("fuelPGasO").innerHTML = fuel.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("synPGasO").innerHTML = syn.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("servPGasO").innerHTML = inspection.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("chargPGasO").innerHTML = "N/A";
    document.getElementById("subPGasO").innerHTML = "N/A";

    document.getElementById("totalPGas").innerHTML = total.toFixed(2).toString().replace(".", ",") + " kr";
}

function calculateInspectionPrice() {
    if (kmDriven == "") {
        return serv;
    }
    var inspecAmount = (parseFloat(kmDriven) / 15000);

    if (inspecAmount < 1) {
        return serv;
    }
    else {
        return inspecAmount * serv;
    }
}



function calcElectricityPrice() {
        kmDriven = document.getElementById("kmYear").value;
    if (kmDriven != "") {
        electUseElec = parseFloat(document.getElementById("useKmElecI").innerHTML.replace(',', "."));
        electUseElec = electUseElec / 1000;
        var elP = electP;
        if (ownership == "Rent") {
            elP -= ref;
        }
        return (elP * electUseElec) * kmDriven;
    }
    return 0;
}

function calculateElecCar() {
    newPElec = parseFloat(document.getElementById("newPElecI").innerHTML);
    var fuel = parseFloat(calcElectricityPrice());
    var inspection = parseFloat(calculateInspectionPrice());
    var year = document.getElementById("currentTab").innerHTML;
    var total, extra;
    syn = 0;
    charger = 5500;
    startprice = 8542.85;
    sub = 180;
    if (ownership == "Rent") {
        extra = sub;
    }
    else {
        extra = 0;
    }

    if (year == "all") {
        total += newPElec;
        syn = 490;
        total = newPElec;
        fuel *= 5;
        extra *= 5;
        inspection *= 5;
        if (ownership == "Rent") {
            extra += startprice;
            charger = 0;
        }
        else {
            total += charger;
            startprice = 0;
        }
        total += syn + fuel + extra + inspection;
    }
    else {
        total = fuel + inspection + extra;
        if (year == "1") {
            total += newPElec;
            if (ownership == "Rent") {
                total += startprice;
                extra += startprice;
                charger = 0;
            }
            else {
                total += charger;
                startprice = 0;
            }
        }
        else if (year == "4") {
            syn = 490;
            total += syn;
            startprice = 0;
            charger = 0;
        }
        else {
            startprice = 0;
            charger = 0;
            newPElec = 0;
        }
    }

    document.getElementById("newPElecO").innerHTML = newPElec.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("electPElecO").innerHTML = fuel.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("synPElecO").innerHTML = syn.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("servPElecO").innerHTML = inspection.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("chargPElecO").innerHTML = charger.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("subPElecO").innerHTML = extra.toFixed(2).toString().replace(".", ",") + " kr";
    document.getElementById("totalPElec").innerHTML = total.toFixed(2).toString().replace(".", ",") + " kr";
}


