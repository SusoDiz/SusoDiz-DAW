namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaximoElemento = 15;
            int[] lista = new int[MaximoElemento];
            int suma = 0;
            for (int contador = 1; contador < MaximoElemento; contador++)
            {
                suma = suma + contador;
                lista[contador - 1] = suma;
            }

            for (int contador = 0; contador < MaximoElemento; contador++)
                Console.WriteLine("El elemento con el índice {0} contiene {1}.", contador, lista[contador]);
            Console.WriteLine("\nPulse cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}