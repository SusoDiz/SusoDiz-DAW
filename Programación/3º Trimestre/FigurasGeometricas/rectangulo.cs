using System.Drawing;
using System.Runtime.CompilerServices;

public class Rectangulo:Figura
{

    private int alto;
    private int ancho;
    private Punto posicion;
    private Figura Figura;

    public Rectangulo(int x, int y, int alto, int ancho)
    {
        this.alto = alto;
        this.ancho = ancho;
        posicion = new Punto(x, y);
    }

    public int getAlto()
    {
        return alto;
    }

    public int getAncho()
    {
        return ancho;
    }

    /*public int getX(int x)
    {
        return x;
    }

    public int getY(int y)
    {
        return y;
    }
    */
    public int perimetro()
    {
        return alto + ancho + alto + ancho;
    }

    public override double area()
    {
        return alto * ancho;
    }
}
