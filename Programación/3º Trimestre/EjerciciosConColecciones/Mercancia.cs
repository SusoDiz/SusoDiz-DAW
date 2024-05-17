using TransporteContainers;

namespace TransporteContainers;

public class Mercancia
{
    public const Decimal PESO_MAX_CONTAINER = 1200;

    public String Destino { get; }
    public Decimal Peso { get; }

    public Mercancia(String? pais, Decimal peso)
    {
        if (String.IsNullOrWhiteSpace(pais))
            throw new MercanciasException("Dato de destino inválido");
        if (peso <= 0 | peso > PESO_MAX_CONTAINER)
            throw new MercanciasException("Datos de peso a transportar inválido");
        Destino = pais;
        Peso = peso;
    }
    public override string ToString()
    {
        return $"Mercancía destinada a {Destino}[{Peso}Kg.]";
    }

}