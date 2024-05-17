public class Strings
{
    public static String rTrim(String s)
    {
        String soluc;
        int nChars;
        int i = s.Length - 1;
        if (s.Length != 0)
        {
            while (Char.IsWhiteSpace(s[i]) && i > 0)
                i--;
            if (Char.IsWhiteSpace(s[i]))
                nChars = i; // o bien nChars = 0;
            else
                nChars = i + 1;
            soluc = s.Substring(0, nChars);
        }
        else
            soluc = s;
        return soluc;
    }
    public static String lTrim(String s)
    {
        String soluc;
        int nChars;
        int i = 0;
        if (s.Length != 0)
        {
            while (Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            if (Char.IsWhiteSpace(s[i]))
                nChars = 0;
            else
                nChars = s.Length - i;
            soluc = s.Substring(i, nChars);
        }
        else
            soluc = s;
        return soluc;
    }
    public static String trim(String s)
    {
        return rTrim(lTrim(s));
    }
    public static int numItems(String s)
    {
        int i;
        int nItems = 0;
        Boolean en_Item = false;
        for (i = 0; i < s.Length; i++)
            if (en_Item)
            {
                // Saliendo de palabra
                if (Char.IsWhiteSpace(s[i]))
                    en_Item = false;
            }
            else
            {
                // Entrando en palabra
                if (!Char.IsWhiteSpace(s[i]))
                {
                    en_Item = true;
                    nItems++;
                }
            }
        return nItems;
    }

    public static String[] split(String s)
    {
        int item = 0, i = 0, iniItem, tamItem;
        String[] resul = new String[numItems(s)];

        while (i < s.Length)
        {
            // Acotar item actual
            // Marcar el primer caracter que no sea espacio en blanco.
            while (Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            iniItem = i;
            // Avanzar hasta el caracter que sea espacio en blanco.
            // para calcular tamaño del item.
            tamItem = 0;
            while (!Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            // por si se salió por llegar al final y termina en caracter no espacio.
            tamItem = i - iniItem;
            if (!Char.IsWhiteSpace(s[i]))
                tamItem++;
            if (tamItem != 0)
            {
                resul[item] = s.Substring(iniItem, tamItem);
                item++;
            }
            i++;
        }
        return resul;
    }

    //------------------------------
    // PRUEBAS DE ESTAS FUNCIONES
    //------------------------------
    private static class PruebaFuncStrings
    {
        public static void pruebaTrim()
        {
            int i;
            String s1 = "  \t  Gato Pérez   \n ";
            String s2 = "Gato Pérez   \n ";
            String s3 = "  \t  Gato Pérez";
            String s4 = "      ";
            String s5 = "";
            String[] frasesDePrueba = { s1, s2, s3, s4, s5 };

            for (i = 0; i < frasesDePrueba.Length; i++)
            {
                Console.WriteLine("\n--->" + frasesDePrueba[i] + "<---");
                Console.WriteLine("--->" + Strings.trim(frasesDePrueba[i]) + "<---");
                Console.WriteLine("------------------------\n");
            }
        }

        public static void pruebaNumItems()
        {
            String frase = "-La Cosa,    \t   está que arde.\n- !Cierto!, así es.";
            Console.WriteLine("--->" + frase + "<---");
            Console.WriteLine(Strings.numItems(frase) + " items.");
        }

        public static void pruebaSplit()
        {
            String frase1 = "-La Cosa,   está que arde.\n- !Cierto!, así es.";
            String frase2 = "-La Cosa, está que arde.\n- !Cierto!, así es. ";
            String frase3 = "-La \"Cosa\", está que arde.\t-!Cierto!, así es. ";
            String frase4 = "";
            String frase5 = "-";
            String frase6 = " ";

            String[] troceado;
            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase1);
            Console.WriteLine("--->" + frase1 + "<---\n");
            Tablas.mostrar(troceado);
            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase2);
            Console.WriteLine("--->" + frase2 + "<---\n");
            Tablas.mostrar(troceado);
            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase3);
            Console.WriteLine("--->" + frase3 + "<---\n");
            Tablas.mostrar(troceado);


            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase4);
            Console.WriteLine("--->" + frase4 + "<---\n");
            Tablas.mostrar(troceado);
            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase5);
            Console.WriteLine("--->" + frase5 + "<---\n");
            Tablas.mostrar(troceado);
            Console.WriteLine("-----------------------------------------");
            troceado = Strings.split(frase6);
            Console.WriteLine("--->" + frase6 + "<---\n");
            Tablas.mostrar(troceado);
        }
    }


}


