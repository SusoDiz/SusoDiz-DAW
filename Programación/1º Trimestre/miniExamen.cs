namespace MiniExamenBien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int unidades;
            int edad, anteriorEdad = 0;

            Console.WriteLine("Introduce una edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            while (edad != -1)
            {
                unidades = edad % 10;
                if (edad >= anteriorEdad && unidades != 5)
                    total = total + edad;
                anteriorEdad = edad;
                Console.WriteLine("Siguiente: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}