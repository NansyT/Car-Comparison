const labels = [
    '1. år',
    '2. år',
    '3. år',
    '4. år',
    '5. år'
];

const data = {
    labels: labels,
    datasets: [{
        label: 'Benzin bil',
        backgroundColor: 'rgb(255, 99, 132)',
        borderColor: 'rgb(255, 99, 132)',
        data: [finPrices.year1G, finPrices.year2G, finPrices.year3G, finPrices.year4G, finPrices.year5G],
    },
        {
        label: 'El bil',
        backgroundColor: 'rgb(70, 255, 0)',
            borderColor: 'rgb(70, 255, 0)',
        data: [finPrices.year1E, finPrices.year2E, finPrices.year3E, finPrices.year4E, finPrices.year5E],
    }]
};

const config = {
    type: 'line',
    data: data,
    options: {}
};


const myChart = new Chart(
    document.getElementById('myChart'),
    config
);