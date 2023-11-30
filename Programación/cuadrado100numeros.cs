namespace CuadradoDe100Numeros;
internal class Program
{
    static void Main(string[] args)
    {
        int numero;
        const int LINEAS = 10;
        const int TOPE = 105;
        numero = 1;
        for ( ; numero <= TOPE; )
        {
            for (int j = 1; j <= LINEAS && numero <= TOPE; j++)
            {
                Console.Write("\t"+(numero++));
            }
            Console.Write('\n');
        }
    }
}