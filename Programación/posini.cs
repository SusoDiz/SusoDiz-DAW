namespace Posini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabraOriginal;
            int palabraAleatoria;

            Random numAleatorio = new Random();

            String[] listaPalabras = { "ordenador", "manzana", "botella", "automovil", "programacion" };

            palabraAleatoria = numAleatorio.Next(0, 4);
            palabraOriginal = listaPalabras[palabraAleatoria];

            int posicion = numAleatorio.Next(0, palabraOriginal.Length);

            string parte1 = palabraOriginal.Substring(0, posicion);
            string parte2 = palabraOriginal.Substring(posicion);

            string palabraNueva = parte2 + parte1;

            Console.WriteLine("Adivina la palabra: " + palabraNueva);
            string palabraUsuario = Console.ReadLine();

            if (palabraUsuario.ToLower() == palabraOriginal.ToLower())
            {
                Console.WriteLine("Has adivinado la palabra!");
            }
            else
            {
                Console.WriteLine("Incorrecto. La palabra correcta es: " + palabraOriginal);
            }

        }
    }
}
