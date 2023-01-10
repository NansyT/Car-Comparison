var inspec = 490;
var serv = 3500;

//Price for gas
var fuelP = 17.7325;

//Average price for a subscription (times 12 to get a years price)
var sub = 180 * 12;

//'Refusion' on electricity (only applicable if the car is charged with electricity through a subscription)
var ref = 1.06;

//Raw electric price
//Notes: Price for kWh/h is not precise.
//We have used the average-ish price from https://elberegner.dk/elpriser/
var electP = 3.25;

//Only applicable when a subscription is active
//This is costs for starting up a subscription
var startprice = 8542.85;

//Price for charger (applicable when there is no subscription)
var charger = 5500;

//Used to hold prices for the chart
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


//This gets called every time the page is loaded
window.onload = function () {
    //checks the status for charger (rent or own) and sets a check in the correct checkbox
    var status = document.getElementById("ownStatus").innerHTML;
    if (status == "Rent") {
        document.getElementById("electricRadioRent").checked = true;
        console.log(status);
    }
    else if (status == "Own") {
        document.getElementById("electricRadioOwn").checked = true;
        console.log(status);
    }
    

    //Sets eventlistener on the textbox for km driven to make sure calculations are run when the km is changed.
    //Not needed when using the virtual keyboard. Using the kmCalc() Method instead (look alittle further down)
    //document.getElementById("kmYear").addEventListener('change', function () {
    //    calcGas();
    //    calcElec();
    //    SetKmYear();
    //    chart();
    //})
    calcElec();
    calcGas();

    //Sets eventlistener on the radio buttons to make sure calculations are run when it is changed.
    document.getElementById("electricRadioRent").addEventListener('change', function () {
        SetOwnership("Rent");
        calcElec();
        calcGas();
        chart();
    })

    //Sets eventlistener on the radio buttons to make sure calculations are run when it is changed.
    document.getElementById("electricRadioOwn").addEventListener('change', function () {
        SetOwnership("Own");
        calcElec();
        calcGas();
        chart();
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
                chart();
            }
        })
    }
}

//Gets used by the keyboard to update the km driven instead of making an event listener for kn driven textbox
function kmCalc() {
    calcGas();
    calcElec();
    SetKmYear();
    chart();
}

//
function SetOwnership(ownership) {
    let ur = currentURL + 'Home/SetOwnership?owner=' + ownership;
    $.ajax({
        url: ur,
        type: 'POST',
        success: function () {
        },
        error: function (error) {
            if (error) {
                console.log(error);
            }
        }
    });
}

//
function SetKmYear() {
    let ur = currentURL + 'Home/SetkmPeryear';
    $.ajax({
        url: ur,
        type: 'POST',
        dataType: 'json',
        data: {
            "kmYear": document.getElementById("kmYear").value
        },
        success: function () {
        },
        error: function (error) {
            if (error) {
                console.log(error);
            }
        }
    });
}

//Used to calculate gas cars
function calcGas() {
    if (document.getElementById("chosenGasCarBrand") != null) {
        calcCar("gas");
    }
}

//Used to calculate electric cars
function calcElec() {
    if (document.getElementById("chosenElecCarBrand") != null) {
        calcCar("elec");
    }
}

//Calculates the price for fuel for the fuel needed for the given km
function calculateFuelPrice(km) {
    if (km != "") {
        //Gets the amount of fuel needed pr km
        let fuelUse = parseFloat(document.getElementById("useKmGasI").innerHTML.replace(',', "."));
        return (km / fuelUse) * fuelP;
    }
    return 0;
}

//Calculates the service inspection price (this may not be accurate). It takes the amount of km driven to calculate
function calculateServInspecPrice(km) {
    if (km != "") {
        //Calcualtes how many times the car needs an inspection a year
        var inspecAmount = (parseFloat(km) / 15000);

        //If the amount of inspections i more than one we calculate what it will cost
        if (inspecAmount > 1) {
            return inspecAmount * serv;
        }
    }
    //Otherwise we can just return the price for one inspection
    return serv;
}

//Calculates the price for electricity for a year, takes parameters of how many km driven in a year and ownership of the charger
function calcElectricityPrice(km, ownership) {
    if (km != "" || (ownership != "Own" && ownership != "Rent")) {
        //Retrieves the cars engergyconsumption in Wh/km and parses it to float (and changes it to the danish decimal point)
        let electUseElec = parseFloat(document.getElementById("useKmElecI").innerHTML.replace(',', "."));
        //Converts the energyconsumption to kWh
        electUseElec = electUseElec / 1000;
        var elP = electP;
        //Checks if the charger is rented (if yes, 'refusion' is subtracted)
        if (ownership == "Rent") {
            elP -= ref;
        }
        //Electricity price is timed with the amount of kWh used on a km and then timed with how many km is driven
        return (elP * electUseElec) * km;
    }
    return 0;

}

//Calculates the prices for a car (parameter to indicate wheter gas car or electric car)
function calcCar(car) {
    //Gets the km driven in a year
    let kmDriven = document.getElementById("kmYear").value;
    let newPrice;
    let ownership = "";
    //Gets the price for a years service inspection
    let servIns = calculateServInspecPrice(kmDriven);
    //Gets which total to calculate
    let year = document.getElementById("currentTab").innerHTML;
    let fuel, outPrices;
    let prices = new Object;
    //If to calculate stuff that's included in every total price, for either gas or electric car and get the price of the car
    if (car == "gas") {
        fuel = calculateFuelPrice(kmDriven);
        newPrice = parseFloat(document.getElementById("newPGasI").innerHTML);
    }
    else if (car == "elec") {
        //Sets wheter the charger is checked to be rented or owned
        if (document.getElementById("electricRadioRent").checked) {
            ownership = "Rent";
        }
        else if (document.getElementById("electricRadioOwn").checked) {
            ownership = "Own";
        }
        fuel = calcElectricityPrice(kmDriven, ownership);
        newPrice = parseFloat(document.getElementById("newPElecI").innerHTML);
    }
    //Used to calculate right total price
    switch (year) {
        case "1":
            outPrices = calcYear1(car, newPrice, fuel, servIns, ownership);
            break;
        case "4":
            outPrices = calcYear4(car, fuel, servIns, ownership);
            newPrice = 0;

            break;
        case "all":
            outPrices = calcAll(car, newPrice, fuel, servIns, ownership);
            fuel *= 5;
            servIns *= 5;
            break;
        default:
            outPrices = calcYearWithoutServ(car, fuel, servIns, ownership);
            newPrice = 0;
            break;
    }
    //Save the prices in an object for later use
    prices.new = newPrice;
    prices.fuel = fuel;
    prices.ins = outPrices.ins;
    prices.serv = servIns;
    prices.extra = outPrices.extra;
    prices.total = outPrices.total;

    setText(car, prices, ownership);
}

//Calculates the first year
function calcYear1(car, newP, fuel, servIns, ownership) {
    //Calculates the price with what is always needed
    let total = newP + fuel + servIns;
    let extra = 0;
    //Calculates the electric exclusive stuff
    if (car == "elec") {
        if (ownership == "Rent") {
            extra = startprice + sub;
        }
        else if (ownership == "Own") {
            extra = charger;
        }
        //Adds it to the total price
        total += extra;
    }
    return { total, extra, ins: 0 };
}

//Calculates the fourth year
function calcYear4(car, fuel, servIns, ownership) {
    let total = fuel + servIns + inspec;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra += sub;
        }
        total += extra;
    }
    return { total, extra, ins: inspec };
}

//Calculates the total of all five years
function calcAll(car, newP, fuel, servIns, ownership) {
    let total = newP + (fuel * 5) + (servIns * 5) + inspec;
    let extra = 0;
    if (car == "elec") {
        if (ownership == "Rent") {
            extra = (sub * 5) + startprice;
        }
        else if (ownership == "Own") {
            extra = charger;
        }
        total += extra;
    }
    calcGraph(car, newP, fuel, servIns);
    return { total, extra, ins: inspec };
}

//Used to calculate all years after the first where there is no service 
function calcYearWithoutServ(car, fuel, servIns, ownership) {
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

//Set all the prices that he chart needs
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
    else if (car == "elec") {
        finPrices.year1E = year1.total;
        finPrices.year2E = year235.total;
        finPrices.year3E = year235.total;
        finPrices.year4E = year4.total;
        finPrices.year5E = year235.total;
    }
}

//Fills out the table of textboxes with calculated prices
function setText(car, prices, ownership) {
    //Gas car
    if (car == "gas") {
        document.getElementById("newPGasO").innerHTML = prices.new.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("fuelPGasO").innerHTML = prices.fuel.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("synPGasO").innerHTML = prices.ins.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("servPGasO").innerHTML = prices.serv.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("chargPGasO").innerHTML = "N/A";
        document.getElementById("subPGasO").innerHTML = "N/A";
        document.getElementById("totalPGas").innerHTML = prices.total.toFixed(2).toString().replace(".", ",") + " kr";
    }
    //Electric car
    else if (car == "elec") {
        document.getElementById("newPElecO").innerHTML = prices.new.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("electPElecO").innerHTML = prices.fuel.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("synPElecO").innerHTML = prices.ins.toFixed(2).toString().replace(".", ",") + " kr";
        document.getElementById("servPElecO").innerHTML = prices.serv.toFixed(2).toString().replace(".", ",") + " kr";
        //Renting charger
        if (ownership == "Rent") {
            document.getElementById("chargPElecO").innerHTML = "0,00 kr";
            document.getElementById("subPElecO").innerHTML = prices.extra.toFixed(2).toString().replace(".", ",") + " kr";
        }
        //Owning charger
        else if (ownership == "Own") {
            document.getElementById("chargPElecO").innerHTML = prices.extra.toFixed(2).toString().replace(".", ",") + " kr";
            document.getElementById("subPElecO").innerHTML = "0,00 kr";
        }
        //Not specified wheter renting or owning
        else {
            document.getElementById("chargPElecO").innerHTML = "0,00 kr";
            document.getElementById("subPElecO").innerHTML = "0,00 kr";
        }
        document.getElementById("totalPElec").innerHTML = prices.total.toFixed(2).toString().replace(".", ",") + " kr";
    }
}