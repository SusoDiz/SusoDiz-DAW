namespace Ejercicio_504_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linea;
            int num, max, min, total, cont;
            Decimal media;
            char crearNuevo = 'S';
            #region Menu
            int nOpcion;
            String nFichero = "numeros.dat";
            Menu menu = new Menu();
            menu.añadir("Crear Fichero");
            menu.añadir("Introducir números");
            menu.añadir("Valor máximo");
            menu.añadir("Valor mínimo");
            menu.añadir("Media de valores");
            menu.añadir("Salir");
            #endregion

            menu.mostrar();
            nOpcion = menu.leer();
            while (nOpcion != -1 && nOpcion != menu.getOpciones())
            {
                switch (nOpcion)
                {
                    case 1:
                        Console.Write("Nombre del fichero a crear: ");
                        nFichero = Console.ReadLine();
                        if (File.Exists(nFichero))
                        {
                            Console.Write("El fichero ya existe. \nLo quiere sobreescribir? (s/n) ");
                            crearNuevo = Console.ReadLine().Trim().ToUpper()[0];
                        }
                        if (crearNuevo == 'S')
                            File.Create(nFichero).Close();
                        break;

                    case 2:
                        using (BinaryWriter bw = new BinaryWriter(new FileStream(nFichero, FileMode.Append, FileAccess.Write)))
                        {
                            Console.WriteLine("Introduzca valores numéricos (0 para salir): ");
                            linea = Console.ReadLine().Trim();
                            while (!linea.Equals("0"))
                            {
                                try
                                {
                                    int valor = Convert.ToInt32(linea);
                                    bw.Write(valor);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine($"{linea} no es un número.");
                                }
                                linea = Console.ReadLine().Trim();
                            }
                        }
                        break;
                    case 3:
                        try
                        {
                            using (StreamReader sr = new StreamReader(nFichero))
                            {
                                max = Int32.MinValue;
                                while ((linea = sr.ReadLine()) != null)
                                {
                                    try
                                    {
                                        num = Convert.ToInt32(linea);
                                        if (num > max)
                                            max = num;
                                    }
                                    catch (FormatException)
                                    {
                                    }
                                    catch (OverflowException) { }
                                }
                            }
                            Console.WriteLine($"El número máximo de fichero '{nFichero}' es {max}.");
                        }
                        catch (IOException)
                        {
                            Console.WriteLine($"El fichero '{nFichero}' no se encuentra.");
                        }
                        break;
                    case 4:
                        try
                        {
                            using (StreamReader sr = new StreamReader(nFichero))
                            {
                                min = Int32.MaxValue;
                                while ((linea = sr.ReadLine()) != null)
                                {
                                    try
                                    {
                                        num = Convert.ToInt32(linea);
                                        if (num < min)
                                            min = num;
                                    }
                                    catch (FormatException) { }
                                    catch (OverflowException) { }
                                }
                            }
                            Console.WriteLine($"El número mínimo de fichero '{nFichero}' es {min}.");
                        }
                        catch (IOException)
                        {
                            Console.WriteLine($"El fichero '{nFichero}' no se encuentra.");
                        }
                        break;
                    case 5:
                        try
                        {
                            using (StreamReader sr = new StreamReader(nFichero))
                            {
                                total = cont = 0;

                                while ((linea = sr.ReadLine()) != null)
                                {
                                    try
                                    {
                                        num = Convert.ToInt32(linea);
                                        total += num;
                                        cont++;
                                    }
                                    catch (FormatException) { }
                                    catch (OverflowException) { }
                                }
                            }
                            if (cont != 0)
                            {
                                media = total / (decimal)cont;
                                Console.WriteLine($"La media de los números del fichero '{nFichero}' es {media:f2}.");
                            }
                            else
                                Console.WriteLine("No hay datos en el fichero '{nFichero}' para la media.");
                        }
                        catch (IOException)
                        {
                            Console.WriteLine($"El fichero '{nFichero}' no se encuentra.");
                        }
                        break;

                }
                menu.mostrar();
                nOpcion = menu.leer();
            }


        }
    }
}
