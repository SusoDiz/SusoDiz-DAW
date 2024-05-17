namespace MetroTenerife
{
    public class Pasajero
    {
        public string Nombre { get; private set; } // ¿Privada para que no le cambien el nombre al pasajero?

        public Pasajero(string nombre)
        {
            Nombre = nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}
