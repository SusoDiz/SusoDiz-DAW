namespace examenPrimerTrimestre2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiempo;
            int[] tabla = new int[3];

            Console.WriteLine("Segundos: ");
            tiempo = Convert.ToInt32(Console.ReadLine());

            tabla[0] = (tiempo%60); //Segundos
            tabla[1] = (tiempo%60); //Minutos
            tabla[2] = (tiempo / 3600); //Horas

            if (tabla[2] > 24)
            {
                tabla[2] = 24;
            }

            Console.WriteLine(tabla[2] + " horas, " + tabla[1] + " minutos, " + tabla[0] + " segundos ");
        }
    }
}