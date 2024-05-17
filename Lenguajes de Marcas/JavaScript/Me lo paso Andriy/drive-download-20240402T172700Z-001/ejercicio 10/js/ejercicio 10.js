function comprobador_palindromo(cadena)
{
    cadena_inversa;
    contador = 0;

    for(i = cadena.length; i > 0; i--)
    {
        cadena_inversa = cadena_inversa + cadena[i];
    }
    for(i = 0; i < cadena.length; i++)
    {
        for(j = 0; j < cadena_inversa.length; j++)
        {
            if(cadena[i] == cadena_inversa[j])
                contador++;
        }
    }
    if (contador > 0)
        alert("Es un palíndromo.")
    else
    {
        alert("No es un palíndromo.")
    }
}

comprobador_palindromo("la ruta nos aporto otro paso natural")