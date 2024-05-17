public class Circulo:Figura
{

    private int radio;
    private int diametro;
    //private Punto posicion;

    public Circulo(int x, int y, int radio)
    {
        this.radio = radio;
        this.diametro = radio * 2;
        posicion = new Punto(x, y);
    }

    public int getRadio()
    {
        return radio;
    }

    public int getDiametro()
    {
        return diametro;
    }

    public int getX(int x)
    {
        return x;
    }

    public int getY(int y)
    {
        return y;
    }

    public double perimetro()
    {
        return 2 * radio * Math.PI;
    }

    public double area()
    {
        return Math.PI * (Convert.ToDouble(radio) * Convert.ToDouble(radio));
    }
}