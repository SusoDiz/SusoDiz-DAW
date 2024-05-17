function AñadirAlFinal() {
    let valor = document.getElementById("casilla").value;
    let lista = document.getElementById("lista");
    let elemento = document.createElement("li");
    elemento.textContent = valor;
    lista.appendChild(elemento);
}

function AñadirAlPrincipio() {
    let valor = document.getElementById("casilla").value;
    let lista = document.getElementById("lista");
    let elemento = document.createElement("li");
    elemento.textContent = valor;
    lista.insertBefore(elemento, lista.firstChild);
}

function BorrarElPrimero() {
    let lista = document.getElementById("lista");
    lista.removeChild(lista.firstChild);
}

function BorrarElUltimo() {
    let lista = document.getElementById("lista");
    lista.removeChild(lista.lastChild);
}

function BorrarTodos() {
    let lista = document.getElementById("lista");
    lista.innerHTML = "";
}

function BorrarElementoClick() {
    let lista = document.getElementById("lista");
    lista.addEventListener("click", function(e) {
        lista.removeChild(e.target);
    });
}

function BorrarElementoDobleClick() {
    let lista = document.getElementById("lista");
    lista.addEventListener("dblclick", function(e) {
        lista.removeChild(e.target);
    });
}