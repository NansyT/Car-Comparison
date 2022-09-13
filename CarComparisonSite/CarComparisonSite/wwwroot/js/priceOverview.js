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

    document.getElementById("kmYear").addEventListener('change', function (e) {
        if (document.getElementById("chosenGasCarBrand") != null) {
            calculateGasCar();
        }
        if (document.getElementById("chosenElecCarBrand") != null) {
            calculateElecCar();
        }
    })

    if (document.getElementById("chosenGasCarBrand") != null) {
        if (document.getElementById("kmYear").value > 0) {
            calculateGasCar();
        }
    }
    if (document.getElementById("chosenElecCarBrand") != null) {
        if (document.getElementById("kmYear").value > 0) {
            calculateElecCar();
        }
    }

    document.getElementById("electricRadioRent").addEventListener('change', function () {
        console.log(document.getElementById("electricRadioRent").checked);
        console.log(document.getElementById("electricRadioOwn").checked);
    })

    document.getElementById("electricRadioOwn").addEventListener('change', function () {
    })


}

function df() {
    if (document.getElementById("kmYear").value > 0) {
        calculateGasCar();
    }
}

function checkKm() {

}
function calculateFuelPrice() {
    kmDriven = parseFloat(document.getElementById("kmYear").value);
    fuelUseGas = parseFloat(document.getElementById("useKmGasI").innerHTML);
    return (kmDriven / fuelUseGas) * fuelP;
}

function calculateGasCar() {
    newGas = parseFloat(document.getElementById("newPGasI").innerHTML);
    var fuel = parseFloat(calculateFuelPrice());
    var inpection = parseFloat(calculateInspectionPrice());
    var year;
    var total;
    if (year == "samlet") {
        total = newGas + syn + fuel
    }
    else {
        total = fuel + inpection;
        if (year == "1") {
            total += newGas;
        }
        else if (year == "4") {
            total += syn;
        }
    }

    document.getElementById("totalPGas").innerHTML = total;
}

function calculateInspectionPrice() {
    var inspecAmount = (parseFloat(kmDriven) / 15000);

    if (inspecAmount < 1) {
        return serv;
    }
    else {
        return inspecAmount * serv;
    }
}



function calcElectricityPrice() {
    kmDriven = parseFloat(document.getElementById("kmYear").value);
    electUseElec = parseFloat(document.getElementById("useKmElecI").innerHTML);
    electUseElec = electUseElec / 1000;
    return (kmDriven / electUseElec) * electP;
}

function calculateElecCar() {
    newPElec = parseFloat(document.getElementById("newPElecI").innerHTML);
    var fuel = parseFloat(calcElectricityPrice());
    var inpection = parseFloat(calculateInspectionPrice());
    var year;
    var total;
    if (year == "samlet") {
        total = newPElec + syn + fuel
    }
    else {
        total = fuel + inpection;
        if (year == "1") {
            total += newGas;
        }
        else if (year == "4") {
            total += syn;
        }
    }

    document.getElementById("totalPElec").innerHTML = total;
}


