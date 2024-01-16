namespace funcion1al100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            contar();
        }

        static void contar()
        {
            int numero = 1;
            Console.Write("\t | ");

            for (int i = 1; i < 101; i++)
            {
                Console.Write(numero + "\t | ");
                numero++;
            }
        }
    }
}
