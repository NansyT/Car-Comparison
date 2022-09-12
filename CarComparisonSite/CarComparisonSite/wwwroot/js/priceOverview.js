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

window.onload = function () {
    if (document.getElementById()) {

    }
}

function calculateFuelPrice() {
    kmDriven = document.getElementById("kmYear").innerHTML;
    fuelUseGas = document.getElementById("useKmGasI").innerHTML;
    return (kmDriven / fuelUseGas) * fuelP;
}

function calculateGasCar() {
    newGas = document.getElementById("newPGasI").innerHTML;
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

    document.getElementById("totalPGas").value = total;
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
    kmDriven = document.getElementById("kmYear").innerHTML;
    electUseElec = document.getElementById("useKmElecI").innerHTML;
    electUseElec = electUseElec / 1000;
    return (kmDriven / electUseElec) * electP;
}

function calculateElectricCar() {
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

    document.getElementById("totalPElec").value = total;
}


