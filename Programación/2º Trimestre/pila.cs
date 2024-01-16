static class Pila
{
    public static void Apilar(String[] pila, ref int cima, String dato) // Pila tiene una tabla y el valor de dato
    {
        pila[cima + 1] = dato;
        cima++;
    }

    public static String Desapilar()
    {
        
        return;
    }

    public static Boolean Vacia()
    {
        
        return;
    }

    public static Boolean Llena(String[] pila, int cima)
    {
        return pila.Length - 1 == cima;
    }
}
