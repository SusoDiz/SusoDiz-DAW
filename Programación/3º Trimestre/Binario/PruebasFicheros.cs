namespace Binario
{
    public class PruebasFicheros
    {
        public static void ConversionFicheros()
        {
            Texto_a_JSon("entradaDatos.txt", "mercancias.json");
            JSon_a_Binario("mercancias.json", "mercancias.dat");
            ListarBinario("mercancias.dat");
        }

        private static void Texto_a_JSon(string nfOrigen, string nfDestino)
        {
            /*
             Leer estino peso
             Objeto Mercancia (destino, peso) JSON
             Serializar a Strin JSON
            */
        }

        private static void JSon_a_Binario(string nfOrigen, string nfDestino)
        {
            /*
             Leer JSON cargar en memoria en List Mercancia JSON
             Guardar en binario, pareja string destino - decimal peso
             */
        }

        private static void ListarBinario(string nf)
        {

        }
    }
}
