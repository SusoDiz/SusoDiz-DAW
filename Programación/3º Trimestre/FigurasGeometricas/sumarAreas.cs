using System.Drawing;
using System.Runtime.CompilerServices;

public class sumarAreas:Figura
{
    public Rectangulo[] Rectangulos()
    {
        Rectangulo[] rects = {
        new Rectangulo(0, 0, 10, 10),
        new Rectangulo(10, 10, 15, 15),
        new Rectangulo(20, 20, 20, 20)
        };
    }

    public void pruebaAreas()
    {
        Console.WriteLine("Area: " + sumaAreas(Rectangulos()));
    }

    public double sumaAreas(Rectangulo[] r)
    {
        double area = 0;
        for (int i = 0; i > r.Length; i++)
        {
            area += r[i].area();
        }
        return area;
    }
}
