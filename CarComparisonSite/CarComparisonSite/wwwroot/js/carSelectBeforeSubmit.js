inputs = document.querySelectorAll(".clickAbleDiv");
console.log(inputs);
for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("click", e => {
        let myvalue = e.currentTarget.id;
        console.log(myvalue);
        let kmYearval = document.getElementById("kmYear").value;
        $.post("/", { carId: myvalue, kmYear: kmYearval }, function (data) {
            location.reload(true);
        });
    })
}