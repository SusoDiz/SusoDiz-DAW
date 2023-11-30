namespace EdadLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            int limite;
            String[] ListaNombre = new String[5];
            int[] ListaEdad = new int[5];

            for (int i = 0; i != 5; i++)
            {
                Console.WriteLine("Nombre: ");
                nombre = Console.ReadLine();
                ListaNombre[i] = nombre;

                Console.WriteLine("Edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                ListaEdad[i] = edad;
            }
            Console.WriteLine("Edad Limite: ");
            limite = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i != 5; i++)
            {
                if (ListaEdad[i] <= limite) 
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}