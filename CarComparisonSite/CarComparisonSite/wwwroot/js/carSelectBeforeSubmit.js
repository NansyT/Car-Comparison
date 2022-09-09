inputs = document.querySelectorAll(".clickAbleDiv");
console.log(inputs);
for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("click", e => {
        let myvalue = e.currentTarget.id;
        console.log(myvalue);
        $.post("/", { carId: myvalue }, function (data) {
            location.reload(true);
        });
    })
}
