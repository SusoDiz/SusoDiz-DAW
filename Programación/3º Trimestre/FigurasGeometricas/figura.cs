public class Figura
{
    protected Punto posicion;
    public int getX() { return posicion.getX(); }
    public int getY() { return posicion.getY(); }
    public virtual double area() { throw new NotImplementedException(); }
}
