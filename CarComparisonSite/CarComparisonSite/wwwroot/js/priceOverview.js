﻿//THIS
//IS
//IMPORTANT

var inspec = 490;
// Gas car prices
var serv = 3500;
var fuelP = 17.7325;

// Electric car prices
var sub = 180;
var ref = 1.06;
//Raw electric price
//Notes: Price for kWh/h is not precise.
//We have used the average raw price not including any vat
//or other additional costs that may be applied in real life.
var electP = 2.0225;
//with ab
var startprice = 8542.85;
//Uden ab
var charger = 5500;

var ownership;

let finPrices = {
    year1G: 0,
    year2G: 0,
    year3G: 0,
    year4G: 0,
    year5G: 0,
    year1E: 0,
    year2E: 0,
    year3E: 0,
    year4E: 0,
    year5E: 0
};

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
        calcElec();
    })

    document.getElementById("electricRadioOwn").addEventListener('change', function () {
        ownership = "Own";
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
        calcCar("gas");
    }
}

function calcElec() {
    if (document.getElementById("chosenElecCarBrand") != null) {
        calcCar("elec");
    }
}

function calculateFuelPrice(km) {
    if (km != "") {
        let fuelUse = parseFloat(document.getElementById("useKmGasI").innerHTML.replace(',', "."));
        return (km / fuelUse) * fuelP;
    }
    return 0;
}

function calculateServInspecPrice(km) {
    var inspecAmount = (parseFloat(km) / 15000);

    if (inspecAmount < 1) {
        return serv;
    }
    else {
        return inspecAmount * serv;
    }
}

function calcElectricityPrice(km) {
    if (km != "") {
        let electUseElec = parseFloat(document.getElementById("useKmElecI").innerHTML.replace(',', "."));
        electUseElec = electUseElec / 1000;
        var elP = electP;
        if (ownership == "Rent") {
            elP -= ref;
        }
        return (elP * electUseElec) * km;
    }
    return 0;

}

function calcCar(car) {
    let kmDriven = parseFloat(document.getElementById("kmYear").value);
    let newPrice;
    let servIns = calculateServInspecPrice(kmDriven);
    let year = document.getElementById("currentTab").innerHTML;;
    let fuel, outPrices
    let prices = new Object;
    if (car == "gas") {
        fuel = calculateFuelPrice(kmDriven);
        newPrice = parseFloat(document.getElementById("newPGasI").innerHTML);
    }
    else {
        fuel = calcElectricityPrice(kmDriven);
        newPrice = parseFloat(document.getElementById("newPElecI").innerHTML);
    }

    switch (year) {
        case "1":
            outPrices = calcYear1(car, newPrice, fuel, servIns);
            break;
        case "4":
            outPrices = calcYear4(car, fuel, servIns);
            newPrice = 0;
            break;
        case "all":
            outPrices = calcAll(car, newPrice, fuel, serv);
            break;
        default:
            outPrices = calcYearWithoutServ(car, fuel, serv);
            newPrice = 0;
            break;
    }
    prices.new = newPrice;
    prices.fuel = fuel;
    prices.ins = outPrices.ins;
    prices.serv = servIns;
    prices.extra = outPrices.extra;
    prices.total = outPrices.total;

    setText(car, prices);
}

function calcYear1(car, newP, fuel, servIns) {
    let total = newP + fuel + servIns;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra = startprice + sub;
        }
        else {
            extra = charger;
        }
        total += extra;
    }
    return { total, extra, ins: 0 };
}

function calcYear4(car, fuel, servIns) {
    let total = fuel + servIns;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra += sub;
        }
        total += extra;
    }
    return { total, extra, ins: 0 };
}

function calcAll(car, newP, fuel, servIns) {
    let total = newP + (fuel * 5) + (servIns * 5) + inspec;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra = (sub + 5) + startprice;
        }
        else {
            extra = charger;
        }
        total += extra;
    }
    calcGraph(car, newP, fuel, servIns);
    return { total, extra, ins: inspec };
}

function calcYearWithoutServ(car, fuel, servIns) {
    let total = fuel + servIns;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra = sub;
        }
        total += extra;
    }
    return { total, extra, ins: 0 };
}

function calcGraph(car, newP, fuel, servIns) {

    let year1 = calcYear1(car, newP, fuel, servIns);
    let year235 = calcYearWithoutServ(car, fuel, servIns);
    let year4 = calcYear4(car, fuel, servIns);
    if (car == "gas") {

        finPrices.year1G = year1.total;
        finPrices.year2G = year235.total;
        finPrices.year3G = year235.total;
        finPrices.year4G = year4.total;
        finPrices.year5G = year235.total;
    }
    else {
        finPrices.year1E = year1.total;
        finPrices.year2E = year235.total;
        finPrices.year3E = year235.total;
        finPrices.year4E = year4.total;
        finPrices.year5E = year235.total;
    }
}

function setText(car, prices) {
    if (car == "gas") {
        document.getElementById("newPGasO").innerHTML = prices.new;
        document.getElementById("fuelPGasO").innerHTML = prices.fuel;
        document.getElementById("synPGasO").innerHTML = prices.ins;
        document.getElementById("servPGasO").innerHTML = prices.serv;
        document.getElementById("chargPGasO").innerHTML = "N/A";
        document.getElementById("subPGasO").innerHTML = "N/A";
        document.getElementById("totalPGas").innerHTML = prices.total;
    }
    else {
        document.getElementById("newPElecO").innerHTML = prices.new;
        document.getElementById("electPElecO").innerHTML = prices.fuel;
        document.getElementById("synPElecO").innerHTML = prices.ins;
        document.getElementById("servPElecO").innerHTML = prices.serv;
        if (ownership = "Rent") {
            document.getElementById("chargPElecO").innerHTML = 0;
            document.getElementById("subPElecO").innerHTML = prices.extra;
        }
        else {
            document.getElementById("chargPElecO").innerHTML = prices.extra;
            document.getElementById("subPElecO").innerHTML = 0;
        }
        document.getElementById("totalPElec").innerHTML = prices.total;
    }
}