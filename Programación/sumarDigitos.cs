namespace pro.cesar;
public class SumaDigitos
{
    public static void Main(string[] args)
    {
        int suma, numero;
        int resto;

        Console.Write("Dame un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        suma = 0;
        while (numero > 0)
        {
            resto = numero % 10;
            suma = suma + resto;
            numero = numero / 10;
        }
        Console.WriteLine("Las suma de los digitos será " + suma);
    }
}