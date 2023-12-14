namespace ETS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 20;
            int[] listaPasos = new int[TAM];
            int pasos,i;
            int distanciaPasos = 0;
            int contador = 0;

            pasos = Convert.ToInt32(Console.ReadLine());
            while (pasos != distanciaPasos && contador < TAM - 1)
            {
                distanciaPasos += pasos;
                listaPasos[contador] = pasos;
                contador++;
                pasos = Convert.ToInt32(Console.ReadLine());
            }
            if(contador == TAM - 1)
            {
                distanciaPasos += pasos;
                listaPasos[contador] = pasos;
                contador++;

            }

            Console.Write("Los pasos dados han sido: ");
            Console.Write("[ ");
            for (i = 0; i <= contador-2; i++) {
                Console.Write(listaPasos[i] + " , ");
            }
            Console.Write(listaPasos[i] + " ]");

            Console.WriteLine($"\nLa distancia es de {distanciaPasos} pasos");
        }
    }
}