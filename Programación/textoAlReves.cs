namespace TextoAlReves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;

            Console.WriteLine("Introduce una frase: ");
            frase = Console.ReadLine();

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
        }
    }
}
