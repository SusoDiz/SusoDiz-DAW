static class ejercicioFunciones0502
{
    // 1
    public static int MenorValor(int[] numeros)
    {
        int min = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
            {
                min = numeros[i];
            }
        }
        return min;
    }

    // 2
    public static int PosicionMenorValor(int[] numeros)
    {
        int min = numeros[0];
        int pos = 0;
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
            {
                min = numeros[i];
                pos = i;
            }
        }
        return pos;
    }

    // 3
    public static int[] VectorAleatorio(int n)
    {
        Random rand = new Random();
        int[] numeros = new int[n];
        for (int i = 0; i < n; i++)
        {
            numeros[i] = rand.Next(1, 100);
        }
        return numeros;
    }

    // 4
    public static bool EsBisiesto(int año)
    {
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }

    // 5
    public static int NumeroDeCifras(int numero)
    {
        int contador = 0;
        while (numero > 0)
        {
            numero /= 10;
            contador++;
        }
        return contador;
        // return (numero + "").Length;
    }

    // 6
    public static double MediaValores(int[] numeros)
    {
        double suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        return suma / numeros.Length;
    }

    // 7
    public static int ContarLetra(string cadena, char letra)
    {
        int contador = 0;
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == letra)
            {
                contador++;
            }
        }
        return contador;
    }

    // 8
    public static List<int> PosicionesLetra(string cadena, char letra)
    {
        List<int> posiciones = new List<int>();
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == letra)
            {
                posiciones.Add(i);
            }
        }
        return posiciones;
    }
}