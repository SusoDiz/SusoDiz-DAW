namespace EmpresaMercancias;

internal class Program
{
    static void Main(string[] args)
    {
        // Ejecutar programa con entrada de datos
        // chcp 65001 // para leer la ñ
        // type entrada-datos.txt | bin\Debug\net8.0\EmpresaMercancias.exe

        List<Mercancia> mercanciasL = new List<Mercancia>();
        int numMercancia = 1;
        bool continuar = true;
        const Decimal PRECIO_CONTAINER = 100;
        Dictionary<string, decimal> mercanciasPorDestino = new Dictionary<string, decimal>(); // colección de tipo diccionario
        decimal precioKg;

        Console.WriteLine("Ejecutando el programa para el cálculo de precio mercancias.");
        Console.WriteLine("Primero introduce los destinos y pesos de las mercancías de tu empresa." +
            "Escribe '0' en el destino para salir");

        // Mejor hacerlo con lectura anticipada
        while (continuar)
        {
            Console.WriteLine($"Mercancía {numMercancia++}");
            Console.Write("\tDestino: ");
            string pais = Console.ReadLine();

            if (pais == "0")
                continuar = false; // Cambiar el valor de la variable para salir del bucle
            else
            {
                Console.Write("\tPeso: ");
                try
                {
                    decimal peso = Convert.ToDecimal(Console.ReadLine());
                    mercanciasL.Add(new Mercancia(pais, peso)); // añadir el objeto instanciado mercancia
                }
                catch (MercanciaException ex)
                {
                    Console.WriteLine($"Destino o peso mercancía es inválida \n{ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Peso debe ser un número \n{ex.Message}");
                }
            }
        }

        // Mostrar datos introducidos
        foreach (var merca in mercanciasL)
            Console.WriteLine(merca);

        Console.Write("\nPrecio kg (por la carga de contenedores): ");
        precioKg = Convert.ToDecimal(Console.ReadLine());

        // Recorre cada objeto mercancia de la lista mercancias
        foreach (Mercancia m in mercanciasL)
        {
            // Obtenemos el destino de la mercancía actual y lo almacenamos en la variable "clave"
            string clave = m.Destino;

            // Verificamos si el diccionario "mercanciasPorDestino" ya contiene la clave "clave"
            if (mercanciasPorDestino.ContainsKey(clave))
                // Si la clave ya existe en el diccionario, sumamos el peso de la mercancía actual al valor existente
                // mercanciasPorDestino[clave] += mercanciasPorDestino[clave]
                mercanciasPorDestino[clave] = mercanciasPorDestino[clave] + m.Peso;
            else
                mercanciasPorDestino[clave] = m.Peso;
                //mercanciasPorDestino.Add(m.Destino, m.Peso);
        }
        Console.WriteLine("\nLISTADO DE DESTINOS Y CONTENEDORES");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(string.Format($"{"Destino",-15} {"Peso Acumulado",-15} {"Nº contenedores",-15} {"Precio Total",-15}"));

        foreach (String pais in mercanciasPorDestino.Keys)
        {
            Decimal precioTotal;
            decimal pesoTotal = mercanciasPorDestino[pais]; // devuelve valor peso del diccionario mercancia
            int nContenedores = (int)Math.Ceiling(pesoTotal / Mercancia.PESOMAX_CONTAINER);
            //int nContenedores = (int)(pesoTotal / Mercancia.PESOMAX); // división entera
            //if (pesoTotal % Mercancia.PESOMAX != 0) nContenedores++; // si tiene resto distinto de cero sumar 1

            precioTotal = pesoTotal * precioKg + nContenedores * PRECIO_CONTAINER;

            Console.WriteLine($"{pais,-15} {pesoTotal,-15} {nContenedores,-15} {precioTotal,-15}");
        }
    }
}

public class Mercancia
{
    public const decimal PESOMAX_CONTAINER = 1200;

    // Propiedades autogeneradas
    public string Destino { get; }
    public decimal Peso { get; set; }

    public Mercancia(string pais, decimal peso)
    {
        if (String.IsNullOrWhiteSpace(pais))
            throw new MercanciaException("Dato de destino inválido."); // excepción personalizada

        if (peso <= 0 | peso > PESOMAX_CONTAINER)
            throw new ArgumentOutOfRangeException("Datos de peso a transportar inválido.");

        Destino = pais;
        Peso = peso;
    }

    public override string ToString()
    {
        return $"Mercancía destinada a {Destino} [{Peso} Kg.]";
    }
}