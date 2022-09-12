var kmDriven;

// Gas car prices
var newGas;
var fuelUseGas;
var syn = 490;
var serv = 3500;
var fuelP = 17.26;

// Electric car prices
var newPElec;
var electUseElec;
var sub = 180;
var ref = 1.06;
//Raw electric price
var electP = 1.43
//with ab
var startprice = 8542.85;
//Uden ab
var charger = 5500;

document.addEventListener("DOMContentLoaded", function (e) {
    document.getElementById("kmYear").addEventListener('change', function (e) {
        if (document.getElementById("chosenGasCarBrand") != null) {
            console.log("GAS CAR EXISTS");
            calculateGasCar();
        }
        if (document.getElementById("chosenElecCarBrand") != null) {
            console.log("Elec CAR EXISTS");
            calculateElecCar();
        }
    })
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
        }
    })
}


function calculateFuelPrice() {
    kmDriven = document.getElementById("kmYear").value;
    fuelUseGas = parseFloat(document.getElementById("useKmGasI").innerHTML);
    return (kmDriven / fuelUseGas) * fuelP;
}

function calculateGasCar() {
    newGas = document.getElementById("newPGasI").innerHTML;
    var fuel = calculateFuelPrice();
    var inpection = calculateInspectionPrice();
    var year;
    var total;
    if (year == "samlet") {
        total = newGas + syn + fuel
    }
    else {
        total = fuel + inpection;
        if (year = "1") {
            total += newGas;
        }
        else if (year = "4") {
            total += syn;
        }
    }

    document.getElementById("totalPGas").innerHTML = total;
}

function calculateInspectionPrice() {
    var inspecAmount = (kmDriven / 15000);

    if (inspecAmount < 1) {
        return serv;
    }
    else {
        return inspecAmount * serv;
    }
}



function calcElectricityPrice() {
    kmDriven = document.getElementById("kmYear").value;
    electUseElec = document.getElementById("useKmElecI").innerHTML;
    electUseElec = electUseElec / 1000;
    return (kmDriven / electUseElec) * electP;
}

function calculateElecCar() {
    newPElec = document.getElementById("newPElecI").innerHTML;
    var fuel = calculateFuelPrice();
    var inpection = calculateInspectionPrice();
    var year;
    var total;
    if (year = "samlet") {
        total = newGas + syn + fuel
    }
    else {
        total = fuel + inpection;
        if (year = "1") {
            total += newGas;
        }
        else if (year = "4") {
            total += syn;
        }
    }

    document.getElementById("totalPElec").innerHTML = total;
}


