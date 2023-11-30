namespace PasosSenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pasos;
            int posicion = 0;
            int distancia = 0;
            
            Console.WriteLine("Pasos: ");
            pasos = Convert.ToInt32(Console.ReadLine()); //3

            while (pasos != distancia) //1º -> 3 != 0 NO //2º -> 3 != 3 SI 
            {
                posicion = posicion + pasos; // 3 = 0 + 3
                distancia = posicion - distancia; // 3 = 3 - 0
                Console.WriteLine("Pasos: ");
                pasos = Convert.ToInt32(Console.ReadLine()); // 3

            }
            Console.WriteLine($"Distancia: {distancia}. Salir...");
        }
    }
}