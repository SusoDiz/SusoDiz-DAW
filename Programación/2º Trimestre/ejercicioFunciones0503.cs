static class ejercicioFunciones0503
{
    // 1
    public static double SumarElementos(double[] array)
    {
        double suma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }
        return suma;
    }

    // 2
    public static double CalcularPromedio(double[] array)
    {
        double suma = SumarElementos(array);
        return suma / array.Length;
    }

    // 3
    public static int BuscarElemento(double[] array, double valor)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                return i;
            }
        }
        return -1; // Devuelve -1 si el valor no se encuentra en el array
    }

    // 4
    public static double[] FiltrarDatos(double[] array, double limite)
    {
        List<double> filtrado = new List<double>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > limite)
            {
                filtrado.Add(array[i]);
            }
        }
        return filtrado.ToArray();
    }

    // 5
    public static double[,] RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas)
    {
        double[,] matrizRecortada = new double[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (inicioFila + i < matrizOriginal.GetLength(0) && inicioColumna + j < matrizOriginal.GetLength(1))
                {
                    matrizRecortada[i, j] = matrizOriginal[inicioFila + i, inicioColumna + j];
                }
            }
        }
        return matrizRecortada;
    }

    // 6
    public static double[,] OrlarMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas)
    {
        double[,] matrizOrlada = new double[filas + 2, columnas + 2];
        for (int i = -1; i <= filas; i++)
        {
            for (int j = -1; j <= columnas; j++)
            {
                if (i >= 0 && i < filas && j >= 0 && j < columnas && inicioFila + i < matrizOriginal.GetLength(0) && inicioColumna + j < matrizOriginal.GetLength(1))
                {
                    matrizOrlada[i + 1, j + 1] = matrizOriginal[inicioFila + i, inicioColumna + j];
                }
                else
                {
                    matrizOrlada[i + 1, j + 1] = 0;
                }
            }
        }
        return matrizOrlada;
    }

}