namespace ETS_exepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 19;
            int numero = 0;

            try
            {
                Console.WriteLine(edad / numero);
            }
            catch
            {
                Console.WriteLine("¡¡¡Hay un error por aqui!!!");
                Console.WriteLine("Pulsa ENTER para salir... ");
                Console.ReadKey();
                return;
            }
            finally
            {
                Console.WriteLine("Edad: " + edad);
            }

        }
    }
}
