inputs = document.querySelectorAll("clickAbleContent");
for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("click", FindCarId, true)
}


function FindCarId(inputTag) {
    var id = inputTag.id;
    console.log(id)
}