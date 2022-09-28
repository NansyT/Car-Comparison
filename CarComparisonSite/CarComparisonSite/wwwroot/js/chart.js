let navLinks = document.querySelectorAll('.nav-link');
for (var i = 0; i < navLinks.length; i++) {
    navLinks[i].addEventListener('click', function (e) {
        if (e.currentTarget.id == "fullTab") {
            document.querySelector(".canvasContainer").hidden = false;
        }
        else {
            document.querySelector(".canvasContainer").hidden = true;
        }
    })
}
let myChart
function chart() {

    //const labels = [
    //    '1. år',
    //    '2. år',
    //    '3. år',
    //    '4. år',
    //    '5. år'
    //];

    //let data = {
    //    labels: labels,
    //    datasets: [{
    //        label: 'Benzin bil',
    //        backgroundColor: 'rgb(255, 99, 132)',
    //        borderColor: 'rgb(255, 99, 132)',
    //        data: [finPrices.year1G, finPrices.year2G += finPrices.year1G, finPrices.year3G += finPrices.year2G, finPrices.year4G += finPrices.year3G, finPrices.year5G += finPrices.year4G],
    //    },
    //    {
    //        label: 'El bil',
    //        backgroundColor: 'rgb(70, 255, 0)',
    //        borderColor: 'rgb(70, 255, 0)',
    //        data: [finPrices.year1E, finPrices.year2E += finPrices.year1E, finPrices.year3E += finPrices.year2E, finPrices.year4E += finPrices.year3E, finPrices.year5E += finPrices.year4E],
    //    }]
    //};

    //const config = {
    //    type: 'line',
    //    data: datas,
    //    options: {}
    //};
    if (document.getElementById("myChart") === null) {
        console.log("null");
        let div = document.createElement('canvas');
        div.id = "myChart";
        document.getElementById("canCon").appendChild(div);
    }
    else {
        document.getElementById("myChart").remove();
        let div = document.createElement('canvas');
        div.id = "myChart";
        document.getElementById("canCon").appendChild(div);
    }
    myChart = new Chart("myChart", {

        type: "line",
        data: {
            labels: ['1. år', '2. år', '3. år', '4. år', '5. år'],
            datasets: [{
                label: 'Benzin bil',
                backgroundColor: 'rgb(255, 99, 132)',
                borderColor: 'rgb(255, 99, 132)',
                data: [finPrices.year1G, finPrices.year2G += finPrices.year1G, finPrices.year3G += finPrices.year2G, finPrices.year4G += finPrices.year3G, finPrices.year5G += finPrices.year4G],
            },
            {
                label: 'El bil',
                backgroundColor: 'rgb(70, 255, 0)',
                borderColor: 'rgb(70, 255, 0)',
                data: [finPrices.year1E, finPrices.year2E += finPrices.year1E, finPrices.year3E += finPrices.year2E, finPrices.year4E += finPrices.year3E, finPrices.year5E += finPrices.year4E],
            }]
        }
    });

}