namespace FiguraAsteriscos_2;
class Program {
    public static void Main(string[] args) {
        int ancho;
        int nAsteriscos;
        int nEspacios=0;

        Console.Write("Qué ancho desea? ");
        ancho = Convert.ToInt32(Console.ReadLine());
        nAsteriscos = ancho;
        for (int i = 1; i <= ancho; i++) {
            for (int j = 1; j <= nEspacios; j++)
            {
                Console.Write(' ');
            }
            for (int j = nAsteriscos; j >= 1; j--)
            {
                Console.Write('*');
            }
            Console.Write('\n');
            nAsteriscos--;
            nEspacios++;
        }
    }
}