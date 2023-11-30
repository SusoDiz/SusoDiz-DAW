using System.ComponentModel.DataAnnotations.Schema;

namespace HundirLaFlota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char agua = '░';
            String sFila = "ABCDEFGHIJ";
            char[,] tablero =
            {
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
                {agua, 'T', 'T', 'T', 'T', agua, agua, agua, agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, 'P', agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, 'P', agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, 'P', agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
                {agua, agua, agua, agua, agua, agua, agua, agua, agua, agua},
            };
            
            for (int i = 0; i < tablero.GetLength(1); i++)
            {
                Console.Write(i + 1);
            }
            Console.WriteLine();
            for (int Fila = 0; Fila < tablero.GetLength(0); Fila++)
             {
                Console.Write(sFila[Fila]);
                for (int Columna = 0; Columna < tablero.GetLength(1); Columna++)
                {
                    Console.Write(tablero[Fila, Columna]);
                }
                Console.WriteLine();
             }
                
        }
    }
}
