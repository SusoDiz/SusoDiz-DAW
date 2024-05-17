namespace MetroTenerife
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Tranvia tranvia = new Tranvia(2); // Crear un tranvía con 2 vagones

                Pasajero p1 = new Pasajero("Juan");
                Pasajero p2 = new Pasajero("Ana");
                Pasajero p3 = new Pasajero("Pedro");

                int vagonJuan = tranvia.Subir(p1, 0); // Subir a Juan al primer vagón
                int vagonAna = tranvia.Subir(p2, 1); // Subir a Ana al primer vagón
                int vagonPedro = tranvia.Subir(p3, 1); // Subir a Pedro al primer vagón

                Console.WriteLine($"Juan subió al vagón {vagonJuan}");
                Console.WriteLine($"Ana subió al vagón {vagonAna}");
                Console.WriteLine($"Pedro subió al vagón {vagonPedro}");

                Pasajero bajado = tranvia.Bajar("Juan", vagonJuan); // Bajar a Juan del vagón donde subió

                if (bajado != null)
                {
                    Console.WriteLine($"{bajado.GetNombre()} ha bajado del tranvía");
                }

                Tranvia.Conductor conductor = new Tranvia.Conductor("Carlos"); 
                tranvia.SetConductor(conductor); 

                tranvia.PuertaAbierta(); 
                tranvia.Subir();
                tranvia.PuertaCerrada();
                tranvia.Avanzar();
                tranvia.Parar();
                tranvia.PuertaAbierta();
                Tranvia.Conductor bajadoConductor = tranvia.Bajar();

                if (bajadoConductor != null)
                {
                    Console.WriteLine($"El conductor {bajadoConductor.GetNombre()} ha bajado del tranvía");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Se produjo un error: {e.Message}");
            }
        }

    }
}
