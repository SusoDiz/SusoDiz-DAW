namespace comprobarNumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("Introduzca un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            primo(numero);

            static void primo(int numero)
            {
                if ( ((numero % numero) == 0) && ((numero % 1) == 0) )
                {
                    Console.WriteLine("Numero Primo");
                } else
                {
                    Console.WriteLine("No es Primo");
                }
            }
        }
    }
}
