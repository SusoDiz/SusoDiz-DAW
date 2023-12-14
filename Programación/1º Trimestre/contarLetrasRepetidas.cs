using System;

namespace ContarLetrasRepetidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Frase;
            char Letra;
            bool LetraAqui;
            int contador;
            int i;

            Console.Write("Dame una frase: ");
            Frase = Console.ReadLine();

            Console.Write("Dame una letra: ");
            Letra = Convert.ToChar(Console.ReadLine());

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