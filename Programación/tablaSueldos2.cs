namespace TablaSueldos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] listaEmpleados = { "Pedro", "Andrea", "Gracia", "Eva" };
            int[,] listaSueldos = new int[3, 4];
            Random NAleatorio = new Random();
            int salarioRandom;
            int MostrarFila;
            int MostrarColumna;
            int cambioRandom;
            int suma;

            for (int Columna = 0; Columna < listaSueldos.GetLength(1); Columna++)
            {
                for (int Fila = 0; Fila < listaSueldos.GetLength(0); Fila++)
                    {
                    salarioRandom = (NAleatorio.Next(100, 201) * 10);
                    listaSueldos[Fila, Columna] = salarioRandom;

                }
            }

            for (int i = 0; i < listaEmpleados.GetLength(0); i++)
            {
                Console.Write(listaEmpleados[i] + "\t");
            }
            Console.Write("\n");
            for (MostrarFila = 0; MostrarFila < listaSueldos.GetLength(0); MostrarFila++)
            {
                for (MostrarColumna = 0; MostrarColumna < listaSueldos.GetLength(1); MostrarColumna++)
                {
                    Console.Write(listaSueldos[MostrarFila, MostrarColumna] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
