namespace Base;
public abstract class Figura
{
    public Punto Posicion { get; }
    public Figura(Punto p)
    {
        Posicion = new Punto(p.X, p.Y);
    }
    public abstract double Area();
    public abstract double Perimetro();
    public override string ToString()
    {
        return $"{GetType().Name}[Posicion:({Posicion.X},{Posicion.Y}) y área {Area():f2}]";
    }
}
