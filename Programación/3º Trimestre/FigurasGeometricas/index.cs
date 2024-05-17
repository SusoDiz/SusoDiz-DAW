using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Index
{
    public static void Main(string[] args)
    {
        // Crear un rectángulo
        Console.WriteLine("RECTANGULO:");
        Rectangulo miRectangulo = new Rectangulo(0, 0, 5, 10);
        Console.WriteLine("Alto del rectángulo: " + miRectangulo.getAlto());
        Console.WriteLine("Ancho del rectángulo: " + miRectangulo.getAncho());
        Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.perimetro());
        Console.WriteLine("Área del rectángulo: " + miRectangulo.area());

        Console.WriteLine();

        // Crear un círculo
        Console.WriteLine("CIRCULO:");
        Circulo miCirculo = new Circulo(0, 0, 7);
        Console.WriteLine("Radio del círculo: " + miCirculo.getRadio());
        Console.WriteLine("Diámetro del círculo: " + miCirculo.getDiametro());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.perimetro());
        Console.WriteLine("Área del círculo: " + miCirculo.area());

    }
}
