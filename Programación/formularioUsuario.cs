namespace FormularioUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MAX_Lista = 20;
            String[] ListaNombres = new String[MAX_Lista];
            int[] ListaTelefonos = new int[MAX_Lista];
            int i = 0;
            String nombre;
            int telefono;
            int BuscaTelefono;
            int PosActual;

            Console.WriteLine("Introduzca su nombre: ");
            nombre = Console.ReadLine();
            ListaNombres[i] = nombre;

            while (nombre != "" & i < MAX_Lista)
            {
                Console.WriteLine("Introduzca su Nº de telefono: ");
                telefono = Convert.ToInt32(Console.ReadLine());
                ListaTelefonos[i] = telefono;

                i++;

                Console.WriteLine("Introduzca su nombre: ");
                nombre = Console.ReadLine();
                ListaNombres[i] = nombre;
            }
            for (int contador = 0; contador < i; contador++) // Poner "i" en vez de "ListaNombres.Lenght" es mejor para no mostrar datos vacios sino se han añadido los {MAX_Lista} datos.
            {
                Console.WriteLine($"Nombre: " + ListaNombres[contador] + " Telefono: " + ListaTelefonos[contador]);
            }
            Console.WriteLine("Busca por Telefono: ");
            BuscaTelefono = Convert.ToInt32(Console.ReadLine());
            PosActual = 0;
            while (BuscaTelefono != ListaTelefonos[PosActual] & PosActual < i - 1)
                PosActual++;
            if (BuscaTelefono == ListaTelefonos[PosActual])
                Console.WriteLine($"");
        }
    }
}