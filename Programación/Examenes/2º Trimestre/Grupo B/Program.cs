public class Program
{
	static void Main(string[] args)
	{
		//PruebaPregunta1a();
		//PruebaPregunta1b();
		//PruebaPregunta2();
	}
	private static void PruebaPregunta1a()
	{
		String[] palabras = { "caja", "percha", "hacha", "sachillo", "guarapo" };
		JuegoAbstracto j = new MemoryBase(palabras);
		if (j.Jugar())
			Console.WriteLine("Enhorabuena. ¡ACERTASTE!");
		else
			Console.WriteLine("Respuesta erronea. ¡Repita y Suerte!");
	}
	private static void PruebaPregunta1b()
	{
		char opcion;
		Boolean recordSuperado;
		String[] palabras = { "rojo", "blanco", "verde", "azul" };
		JuegoAbstracto j = new Memory(palabras);
		do
		{
			recordSuperado = j.Jugar();
			if (recordSuperado)
				Console.WriteLine("\n  >>>  Nuevo Lider: " + j.GetLider() + "  <<<\n");
			Console.WriteLine("Quiere volver a jugar (S/n)?");
			opcion = Char.ToLower(Console.ReadKey().KeyChar);
		} while (opcion != 'n');
		Console.WriteLine("\n\nJuego Terminado\n\nGANADOR: >>> " + j.GetLider() + " <<<\n");
	}

	private static void PruebaPregunta2()
	{
		Punto p00 = new Punto(0, 0);
		Punto p55 = new Punto(5, 5);
		Punto p23 = new Punto(2, 3);
		Console.WriteLine(p00);
		Console.WriteLine(p55);

		//CrearPunto
		Punto p = Punto.CrearPunto(p00, p55);
		Console.WriteLine($"Punto creado: {p}");

		//Distancia
		Console.WriteLine("Distancia al origen: "+p.Distancia(new Punto(0, 0)));

		//EstaDentro
		if (p.EstaDentro(p00, p23))
			Console.WriteLine($"{p} está entre {p00} y {p23}");
		else
			Console.WriteLine($"{p} NO está entre {p00} y {p23}");
	}
}