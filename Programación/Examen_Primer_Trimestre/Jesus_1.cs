namespace examenPrimerTrimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] tabla = new decimal[5];

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = Convert.ToInt32(Console.ReadLine());
            }

            decimal aux = 0;
            for (int i = 0;i < tabla.Length; i++)
            {
                Console.Write(tabla[i] + " ");
                aux = (aux + tabla[i]);

                if (aux >= 100)
                {
                    Console.Write("\\" + aux + "\\" + "\n");
                    aux = 0;
                }
            }
        }
    }
}