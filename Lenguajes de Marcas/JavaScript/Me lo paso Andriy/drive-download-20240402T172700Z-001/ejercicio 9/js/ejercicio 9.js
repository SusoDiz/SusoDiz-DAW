function comprobador_string(cadena)
{
    var cadena_upper = cadena.toUpperCase();
    var cadena_lower = cadena.toLowerCase();

    if(cadena_upper == cadena)
    {
        alert("La cadeba está compuesta por mayúsculas.");
    }
    else
    {
        if(cadena_lower == cadena)
        {
            alert("La cadena está formada por minúsculas.");
        }
        else
        {
            alert("La cadena está formada por minúsculas y mayúsculas.");
        }
    }
}

comprobador_string("aaaAaa")