namespace CalendarioInteractivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            int mes;
            int dia;
            int[] listaMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Dime un año: ");
            año = Convert.ToInt32(Console.ReadLine());
            if (año >= 1)
            {
                // Año valido
                if ((año % 4 == 0) && (año % 100 != 0) || (año % 400 == 0))
                {
                    // Año Bisiesto
                    listaMeses[1] = listaMeses[1] + 1; // Suma 1 a Febrero
                    Console.WriteLine("Dame un mes: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                } else
                {
                    // Año No Bisiesto
                    Console.WriteLine("Dame un mes: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                }

                if ((mes >= 1) && (mes <= 12))
                {
                    // Mes Valido
                    Console.WriteLine("Dame un Día: ");
                    dia = Convert.ToInt32(Console.ReadLine());

                    if ((dia >= 1) && (dia <= listaMeses[mes - 1]))
                    {
                        // Dia Valido
                        Console.WriteLine("Fecha del usuario: " + dia + "/" + mes + "/" + año);
                        Console.WriteLine("Fecha del dispositivo: " + DateTime.Now);


                    }
                    else
                    {
                        // Dia No Valido
                        Console.WriteLine("Día no valido!");
                    }

                } else
                {
                    // Mes No Valido
                    Console.WriteLine("Mes no valido!");
                }

            } else
            {
                // Año No Valido
                Console.WriteLine("Año no valido!");
            }
        }
    }
}