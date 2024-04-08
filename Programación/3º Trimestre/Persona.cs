namespace Personas;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Persona
{
    // atributos de la clase Persona
    private char DniLetra;
    private int DniNumero;
    private string nombre = "Desconocido";
    private int edad;
    public int Edad
    {
        get { return edad; }
        set
        {
            if (edad < 0 && edad > 120)
            {
                throw new Exception("¡Edad no válida!");
            }
            edad = value;
        }
    }
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("¡Nombre no válido!");
            }
            nombre = value;
        }
    }

    // métodos de la clase Persona
    public Persona(int n, char l)
    {
        if (n > 99999999 || n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Número de DNI no válido");
        DniNumero = n;
        DniLetra = LetraDNI(n);
    }
    public override bool Equals(object? obj)
    {
        bool esPersona = false;
        if (obj == null || obj is not Persona) //  GetType() != obj.GetType()
            esPersona = false;  // return false;
        // return this.DniNumero == otraPersona.DniNumero && this.DniLetra == otraPersona.DniLetra;
        else
        {
            Persona otraPersona = (Persona)obj;
            esPersona = this.DniNumero == otraPersona.DniNumero;
        }
        return esPersona;
    }
    public char LetraDNI(int dni)
    {
        if (dni > 99999999 || dni < 0)
            throw new ArgumentOutOfRangeException(nameof(dni), "Número de DNI no válido");
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        return letras[dni % 23];
    }
    public override string ToString()
    {
        return $"{Nombre} con {Edad} años tiene como DNI {DniNumero} {DniLetra}";
    }
}
