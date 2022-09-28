const labels = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
];


const data = {
    labels: labels,
    datasets: [{
        label: 'Benzin bil',
        backgroundColor: 'rgb(255, 99, 132)',
        borderColor: 'rgb(255, 99, 132)',
        data: [0, 10, 5, 2, 20, 30, 45],
    }, {
        label: 'El bil',
        backgroundColor: 'rgb(77, 255, 0)',
        borderColor: 'rgb(77, 255, 0)',
        data: [0, 10, 5, 2, 40, 30, 45],
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