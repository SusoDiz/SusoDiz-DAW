using System.Security.Cryptography.X509Certificates;

namespace funcionContarLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Frase;
            char Letra;

            Console.Write("Dame una frase: ");
            Frase = Console.ReadLine();

            Console.Write("Dame una letra: ");
            Letra = Convert.ToChar(Console.ReadLine());

            contar(Frase, Letra);

            static void contar(String Frase, char Letra)
            {
                bool LetraAqui;
                int contador;
                int i;

                contador = 0;
                for (i = 0; i < Frase.Length; i++)
                {
                    if (Frase[i] == Letra)
                    {
                        contador++;
                    }

                }

                Console.WriteLine($"Número de letras repetidas: {contador}");
            }
        }
    }
}
