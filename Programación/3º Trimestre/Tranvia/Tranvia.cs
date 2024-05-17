namespace MetroTenerife
{
    public class Tranvia
    {
        private Vagon[] vagones;

        public Tranvia() : this(4) { }

        public Tranvia(int numVagones)
        {
            vagones = new Vagon[numVagones];
            for (int i = 0; i < numVagones; i++)
            {
                vagones[i] = new Vagon(10); // Asientos del vagon
            }
        }

        public Pasajero Bajar(string nombre, int vagon)
        {
            if (vagon < 0 || vagon >= vagones.Length)
            {
                throw new Exception("El vagón solicitado no existe");
            }
            return vagones[vagon].Bajar(nombre);
        }

        public int Subir(Pasajero p, int vagon)
        {
            if (vagon < 0 || vagon >= vagones.Length)
            {
                throw new Exception("El vagón solicitado no existe");
            }

            for (int i = vagon; i < vagones.Length; i++)
            {
                try
                {
                    vagones[i].Subir(p);
                    return i;
                }
                catch (Exception) { }
            }

            for (int i = 0; i < vagon; i++)
            {
                try
                {
                    vagones[i].Subir(p);
                    return i;
                }
                catch (Exception) { }
            }

            throw new Exception("No se pudo subir al pasajero a ningún vagón");
        }

        public class Conductor : Pasajero
        {
            public Conductor(string nombre) : base(nombre) { }
        }

        private Conductor conductor;
        private bool puertasAbiertas = false;

        public Conductor SetConductor(Conductor c)
        {
            conductor = c;
            return conductor;
        }

        public Conductor Subir()
        {
            if (puertasAbiertas)
            {
                return conductor;
            }
            else
            {
                throw new Exception("Las puertas están cerradas");
            }
        }

        public Conductor Bajar()
        {
            if (puertasAbiertas)
            {
                Conductor c = conductor;
                conductor = null;
                return c;
            }
            else
            {
                throw new Exception("Las puertas están cerradas");
            }
        }

        public Conductor Avanzar()
        {
            if (conductor == null)
            {
                throw new Exception("No hay conductor");
            }
            else if (puertasAbiertas)
            {
                throw new Exception("No se puede avanzar con las puertas abiertas");
            }
            else
            {
                return conductor;
            }
        }

        public Conductor Parar()
        {
            if (conductor != null)
            {
                return conductor;
            }
            else
            {
                throw new Exception("No hay conductor");
            }
        }

        public Conductor PuertaAbierta()
        {
            if (conductor != null)
            {
                puertasAbiertas = true;
                return conductor;
            }
            else
            {
                throw new Exception("No hay conductor");
            }
        }

        public Conductor PuertaCerrada()
        {
            if (conductor != null)
            {
                puertasAbiertas = false;
                return conductor;
            }
            else
            {
                throw new Exception("No hay conductor");
            }
        }
    }
}
