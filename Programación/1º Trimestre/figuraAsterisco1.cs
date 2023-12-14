namespace FiguraAsteriscos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int nAsteriscos;

            Console.Write("Qué ancho desea? ");
            nAsteriscos = ancho = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ancho; i++)
            {
                for (int j = 1; j<=nAsteriscos  ; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
                nAsteriscos--;
            }
        }
    }
}