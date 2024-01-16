namespace hundirLaFlotaConFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] tablero = new char[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tablero[i, j] = '·'; // Llena el tablero con agua
                }
            }

            int resultado = disparar(tablero, "A1");
            Console.WriteLine("Resultado del disparo en A1: " + resultado);

            resultado = disparar(tablero, "B2");
            Console.WriteLine("Resultado del disparo en B2: " + resultado);

            resultado = disparar(tablero, "A1"); // Disparo repetido
            Console.WriteLine("Resultado del disparo en A1: " + resultado);
        }

        public static int disparar(char[,] tablero, String coordDisparo)
        {
            const char AGUA = '·';
            const char DISPARADO = '*';
            const int COD_AGUA = 1;
            const int COD_TOCADO = 2;
            const int COD_REPETIDO = 3;
            int f;
            int c;
            extraerCoordenada(coordDisparo, out f, out c);

            if (tablero[f, c] == AGUA)
            {
                tablero[f, c] = DISPARADO;
                return COD_AGUA;
            }
            else if (tablero[f, c] == DISPARADO)
            {
                return COD_REPETIDO;
            }
            else
            {
                tablero[f, c] = DISPARADO;
                return COD_TOCADO;
            }
        }

        static void extraerCoordenada(String coordenada, out int fila, out int col)
        {
            fila = (int)coordenada[0] - 'A';
            col = Int32.Parse(coordenada.Substring(1)) - 1;
        }
    }
}
