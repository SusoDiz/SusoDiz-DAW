namespace Base;
public class Circulo : Figura
{
    public int Radio { get; }

    public Circulo(Punto p, int radio) : base(p)
    {
        Radio = Math.Abs(radio);
    }
    public override double Area()
    {
        return Math.PI * Radio * Radio;
    }
    public override double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
