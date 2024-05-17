namespace MetroTenerife
{
    public class Vagon
    {
        private Pasajero[] asientos;

        public Vagon(int capacidad)
        {
            asientos = new Pasajero[capacidad];
        }

        public void Subir(Pasajero pasajero)
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                if (asientos[i] == null)
                {
                    asientos[i] = pasajero;
                    return;
                }
            }
            throw new Exception("No hay asientos libres");
        }

        public Pasajero Bajar(string nombre)
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                if (asientos[i] != null && asientos[i].GetNombre() == nombre)
                {
                    Pasajero pasajero = asientos[i];
                    asientos[i] = null;
                    return pasajero;
                }
            }
            return null;
        }
    }
}
