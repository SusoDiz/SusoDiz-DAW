using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrianguloIso:Figura
{

    private double bas3;
    private double altura;


    public TrianguloIso(double bas3, double altura)
    {
        this.bas3 = bas3;
        this.altura = altura;
    }

    public double getAltura(double altura)
    {
        return altura;
    }

    public double getBase(double bas3)
    {
        return bas3;
    }

    public double ladoHipotenusa()
    {
        return Math.Pow(bas3 / 2, 2) + Math.Pow(altura, 2);
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
        return ladoHipotenusa() * 2 + bas3;
    }

    public double area()
    {
        return bas3 * altura / 2;
    }
}