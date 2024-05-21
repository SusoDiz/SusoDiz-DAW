namespace Base;
public class Punto
{
    public int X { get; }
    public int Y { get; }

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Punto(Punto p) : this(p.X, p.Y) { }

    public override string ToString()
    {
        return $"({X},{Y})";
    }
}
