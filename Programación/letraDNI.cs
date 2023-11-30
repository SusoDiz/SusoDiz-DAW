namespace LetraDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dni;
            int indice;
            string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            string letraDNI;

            Console.Write("Introduce tu DNI sin letra: ");
            dni = Convert.ToInt32(Console.ReadLine());
            indice = (dni % 23);
            letraDNI = letras[indice];

            Console.WriteLine("La letra de tu DNI es: " + letraDNI);

            // https://www.interior.gob.es/opencms/es/servicios-al-ciudadano/tramites-y-gestiones/dni/calculo-del-digito-de-control-del-nif-nie/
        }
    }
}