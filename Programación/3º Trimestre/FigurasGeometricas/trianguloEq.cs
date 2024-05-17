using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrianguloEq:Figura
{
    private double lado;

    public TrianguloEq(double lado)
    {
        this.lado = lado;
    }

    public double getAltura()
    {
        return (Math.Sqrt(lado * 3) / 2);
    }

    public double getBase()
    {
        return lado;
    }

    public double perimetro()
    {
        return lado * 3;
    }

    public double area()
    {
        return getBase() * getAltura();
    }
}
