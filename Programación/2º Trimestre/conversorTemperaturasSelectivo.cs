namespace conversorTemperaturasSelectivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosCelcius;
            char unidad;

            Console.Write("Introduce la temperatura Celcius (ºC): ");
            gradosCelcius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la temperatura a convertir (F ó K): ");
            unidad = Convert.ToChar(Console.Read());

            if (unidad == 'F')
            {
                Console.Write("Temperatura en Fahrenheit: ");
                Fahrenheit(gradosCelcius);
            } else
            {
                if (unidad == 'K')
                {
                    Console.Write("Temperatura en Kelvin: ");
                    Kelvin(gradosCelcius);
                }
            }
        }

        public static void Fahrenheit(double gradosCelcius)
        {
            double gradosFahrenheit;

            gradosFahrenheit = (gradosCelcius * 1.8) + 32;
            Console.WriteLine(gradosFahrenheit + " ºF");
        }

        public static void Kelvin(double gradosCelcius)
        {
            double gradosKelvin;

            gradosKelvin = (gradosCelcius + 273.15);
            Console.WriteLine(gradosKelvin + " K");
        }
    }
}
