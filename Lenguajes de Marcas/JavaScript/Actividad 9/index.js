function letras() {
    var h1 = document.getElementById("frase");
    var phrase = h1.innerText;
    var uppercasePhrase = phrase.toUpperCase();
    var squaredPhrase = "";

    for (var i = 0; i < uppercasePhrase.length; i++) {
        if (uppercasePhrase[i] !== " " && uppercasePhrase[i] !== "," && uppercasePhrase[i] !== ".") {
            squaredPhrase += '<a>' + uppercasePhrase[i] + '</a>';
        } else {
            squaredPhrase += " ";
        }
    }

    h1.innerHTML = squaredPhrase;
}

