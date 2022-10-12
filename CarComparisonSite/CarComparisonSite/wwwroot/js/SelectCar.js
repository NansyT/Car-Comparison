inputs = document.querySelectorAll(".clickAbleDiv");
/*console.log(inputs);*/
for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("click", e => {
        //console.log(myvalue);
        $.post("/", { carId: e.currentTarget.id }, function (data) {
            location.reload(true);
        });
    })
}