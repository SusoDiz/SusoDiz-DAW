namespace conversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosCelcius;

            Console.Write("Introduce la temperatura Celcius (ºC): ");
            gradosCelcius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Temperatura en Fahrenheit: ");
            Fahrenheit(gradosCelcius);

            Console.Write("Temperatura en Kelvin: ");
            Kelvin(gradosCelcius);
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
