namespace TextoAlRevesMasVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            int j;

            Console.WriteLine("Introduce una frase: ");
            frase = Console.ReadLine();
            j = 0;

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                char[] listaReves = new char[frase.Length];
                listaReves[j] = frase[i];
                j++;
                Console.Write(listaReves);
            }
        }
    }
}
