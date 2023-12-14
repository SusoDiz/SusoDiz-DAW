namespace ContarCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Letras;
            
            Console.Write("Dame caracteres: ");
            Letras = Console.ReadLine();

            Console.WriteLine("Número de caracteres: " + Letras.Length);
        }
    }
}