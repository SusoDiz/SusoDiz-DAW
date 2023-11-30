namespace MediaDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number;
            decimal[] ListaNumeros = new decimal[5];
            decimal media;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numero decimal: ");
                number = Convert.ToDecimal(Console.ReadLine());
                ListaNumeros[i] = number;
            }
            for (int i = 0; i < 1; i++)
            {
                media = ListaNumeros[i] / 5;
                Console.WriteLine("Media: {0}", media);
            }
        }
    }
}