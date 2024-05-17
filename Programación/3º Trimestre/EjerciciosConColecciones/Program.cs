﻿using System.Dynamic;
using TransporteContainers;

namespace Principal;
public class Program
{
    public static void Main(string[] args)
    {
        FaseDos(FaseUno());
    }

    private static List<Mercancia> FaseUno()
    {
        String? pais;
        Decimal peso;
        List<Mercancia> mercancias = new List<Mercancia>();
        using StreamReader sr = new StreamReader("../../entradaDatos.txt");
        string line;

        while ((line = sr.ReadLine()) != null)
        {
            string[] datos = line.Split(',');
            try
            {
                pais = datos[0];
                peso = Convert.ToDecimal(datos[1]);
                mercancias.Add(new Mercancia(pais, peso));
            }
            catch (MercanciasException ex)
            {
                Console.WriteLine($"Destino o peso de mercancia es inválido\n{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Peso debe ser un número\n{ex.Message}");
            }
        }
        foreach (Mercancia m in mercancias)
        {
            Console.WriteLine(m);
        }
        return mercancias;
    }

    private static void FaseDos(List<Mercancia> mercancias)
    {
        // salida de la consola a archivo html con sus etiquetas de html
        using StreamWriter sw = new StreamWriter("../../salidaDatos.html");

        Decimal precioKilo, precioTotal;
        Dictionary<String, Decimal> enviosAgrupados = new Dictionary<String, Decimal>();
        int nConten;
        const int PRECIO_CONTAINER = 100;
        String lineaDeDetalle = "{0,-20}{1,-20}{2,-15}{3,-20}";

        Console.WriteLine("Precio/kilo: ");
        //precioKilo = Convert.ToDecimal(Console.ReadLine());
        precioKilo = 2;

        foreach (Mercancia m in mercancias)
        {
            if (enviosAgrupados.ContainsKey(m.Destino))
                enviosAgrupados[m.Destino] = enviosAgrupados[m.Destino] + m.Peso;
            else
                //enviosAgrupados[m.Destino] = m.Peso;
                enviosAgrupados.Add(m.Destino, m.Peso);
        }

        //$"{linea,5}"

        sw.WriteLine("\n<html><head><title>Mercancias</title><link rel=\"stylesheet\" href=\"./mercancias.css\"></head><body><h1>LISTADO DE DESTINOS Y CONTENEDORES</h1>");
        sw.WriteLine("<strong>----------------------------------</strong>");
        sw.WriteLine("<table>" + lineaDeDetalle, "<th>Destino</th>", "<th>Peso Acumulado</th>", "<th>Nº contenedores</th>", "<th>Precio total</th><br>");

        foreach (String dest in enviosAgrupados.Keys)
        {
            nConten = (int)Math.Ceiling(enviosAgrupados[dest] / Mercancia.PESO_MAX_CONTAINER);
            precioTotal = nConten * PRECIO_CONTAINER + precioKilo * enviosAgrupados[dest];
            sw.WriteLine("<tr>" + lineaDeDetalle, "<td>" + dest + "</td>", "<td>" + enviosAgrupados[dest] + "</td>", "<td>" + nConten + "</td>", "<td>" + precioTotal + "</td></tr>");
        }
        sw.WriteLine($"\n</table><br>Precio por kilo en el contenedor {precioKilo}<br>");
        sw.WriteLine($"Precio por contenedor {PRECIO_CONTAINER}<br>");
        sw.WriteLine($"Peso por contenedor {Mercancia.PESO_MAX_CONTAINER}</body></html>");
        sw.Close();
    }
}