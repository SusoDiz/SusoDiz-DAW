function VerImagen(x){
    let nuevo = document.getElementById(`imagen${x}`).src;
    document.getElementById('imagen-principal').src = nuevo;
}
