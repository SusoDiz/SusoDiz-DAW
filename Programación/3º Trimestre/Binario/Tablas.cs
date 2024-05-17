public class Tablas
{
    public static double[,] creaTabla(int f, int c)
    {
        Random random = new Random();
        double[,] tabla_ramdoms = new double[f, c];
        for (f = 0; f < tabla_ramdoms.GetLength(0); f++)
            for (c = 0; c < tabla_ramdoms.GetLength(1); c++)
                tabla_ramdoms[f, c] = random.NextDouble() * 100;
        return tabla_ramdoms;
    }
    public static String[,] creaTablaString(int f, int c, String pref)
    {
        if (pref == null)
            pref = "V.";
        Random random = new Random();
        String[,] tablaCadenas = new String[f, c];
        for (f = 0; f < tablaCadenas.GetLength(0); f++)
            for (c = 0; c < tablaCadenas.GetLength(1); c++)
                tablaCadenas[f, c] = pref + random.Next(10);
        return tablaCadenas;
    }
    public static int[] creaTabla(int tam)
    {
        int i;
        Random random = new Random();
        int[] tabla_ramdoms = new int[tam];
        for (i = 0; i < tabla_ramdoms.Length; i++)
            tabla_ramdoms[i] = random.Next(1, 100);
        return tabla_ramdoms;
    }
    public static void mostrar(String[,] datos, int anchoCampo)
    {
        int fila, col;
        for (fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0," + anchoCampo + "}", datos[fila, col]);
            Console.WriteLine();
        }
    }
    public static void mostrar(double[,] datos, int anchoCampo)
    {
        int fila, col;
        for (fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0," + anchoCampo + ":f2}", datos[fila, col]);
            Console.WriteLine();
        }
    }
    public static void mostrar(int[] numeros)
    {

        int i;
        Console.Write("{ ");
        for (i = 0; i < numeros.Length - 1; i++)
        {
            Console.Write(" {0,2} ,", numeros[i]);
        }
        if (numeros.Length > 0)
        {
            Console.Write(" {0,2} ", numeros[i]);
        }
        Console.WriteLine(" }");
    }
    public static void mostrar(double[] numeros)
    {

        int i;
        Console.Write("{ ");
        for (i = 0; i < numeros.Length - 1; i++)
        {
            Console.Write(" {0,2} ,", numeros[i]);
        }
        if (numeros.Length > 0)
        {
            Console.Write(" {0,2} ", numeros[i]);
        }
        Console.WriteLine(" }");
    }
    public static void mostrar(String[] palabras)
    {
        int i;
        Console.Write("{");
        for (i = 0; i < palabras.Length - 1; i++)
        {
            Console.Write("\"{0}\",", palabras[i]);
        }
        if (palabras.Length > 0)
        {
            Console.Write("\"{0}\"", palabras[i]);
        }
        Console.WriteLine("}");
    }
	public static void mostrar(Object[] objetos)
	{
		int i;
		Console.Write("{");
		for (i = 0; i < objetos.Length - 1; i++)
		{
			Console.Write(" {0} ,", objetos[i]);
		}
		if (objetos.Length > 0)
		{
			Console.Write(" {0}", objetos[i]);
		}
		Console.WriteLine(" }");
	}
	public static void listar(Object[] objetos)
	{
		int i;
		Console.WriteLine($"Listado de {objetos.Length} datos.");
		for (i = 0; i < objetos.Length; i++)
		{
			Console.WriteLine("- {0}", objetos[i]);
		}
		Console.WriteLine();
	}
	public static void rellenar(int[] datos)
    {
        int i;
        Random random = new Random();
        for (i = 0; i < datos.GetLength(0); i++)
        {
            datos[i] = random.Next(-10, 11);
        }
    }
    public static void rellenar(char[,] datos, char ch)
    {
        int f, c;
        for (f = 0; f < datos.GetLength(0); f++)
            for (c = 0; c < datos.GetLength(1); c++)
                datos[f, c] = ch;
    }
    public static void rellenar(int[] datos, int desde, int hasta)
    {
        int i;
        Random random = new Random();
        for (i = 0; i < datos.GetLength(0); i++)
        {
            datos[i] = random.Next(desde, hasta);
        }
    }
    public static int[] merge(int[] tablaA, int[] tablaB)
    {
        int[] tablaC;
        int i = 0, j = 0, k = 0;

        tablaC = new int[tablaA.Length + tablaB.Length];
        while (i < tablaA.Length && j < tablaB.Length)
        {
            if (tablaA[i] <= tablaB[j])
            {
                tablaC[k] = tablaA[i];
                i++;
            }
            else
            {
                tablaC[k] = tablaB[j];
                j++;
            }
            k++;
        }

        while (i < tablaA.Length)
        {
            tablaC[k] = tablaA[i];
            k++;
            i++;
        }
        while (j < tablaB.Length)
        {
            tablaC[k] = tablaB[j];
            k++;
            j++;
        }
        return tablaC;
    }

    public static int[] concat(int[] tablaA, int[] tablaB)
    {
        int i, j;
        int[] tablaC;

        tablaC = new int[tablaA.Length + tablaB.Length];

        for (i = 0; i < tablaA.Length; i++)
        {
            tablaC[i] = tablaA[i];
        }

        for (j = 0; j < tablaB.Length; j++, i++)
        {
            tablaC[i] = tablaB[j];
        }
        return tablaC;
    }



    // Bidimensionales
    public static void rellenar(int[,] datos)
    {
        Random random = new Random();

        for (int fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (int col = 0; col < datos.GetLength(1); col++)
                datos[fila, col] = random.Next(-10, 11);
        }
    }
    public static void mostrar(int[,] datos)
    {
        int fila, col;
        for (fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0,5}", datos[fila, col]);
            Console.WriteLine();
        }

    }
    public static void mostrar(char[,] datos)
    {
        int fila, col;
        for (fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0,3}", datos[fila, col]);
            Console.WriteLine();
        }

    }
}