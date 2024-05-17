public class Menu
{
    private String[] opciones = new String[10];
    private int nOpciones;

    public void añadir(String op)
    {
        if (llena())
            throw new Exception();
        opciones[nOpciones] = op;
        nOpciones++;
    }
    private Boolean llena()
    {
        return opciones.Length == nOpciones;
    }

    public int getOpciones()
    {
        return nOpciones;
    }
    public String getOpcion(int pos)
    {
        if (pos < 0 || pos >= nOpciones)
            throw new ArgumentOutOfRangeException();
        return opciones[pos];
    }
    public void mostrar()
    {
        if (nOpciones == 0)
            throw new Exception("No hay ninguna opción para mostrar");
        for (int i = 0; i < nOpciones; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, opciones[i]);
        }
    }
    public int leer()
    {
        int opcion = -1;
        int intentos = 0;
        do
        {
            try
            {
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e) { }
            catch (OverflowException e) { }
            intentos++;
        } while (intentos < 3 && opcionInvalida(opcion));
        if (opcionInvalida(opcion))
            throw new Exception("Número máximo de intentos alcanzados.");
        return opcion - 1;
    }
    private Boolean opcionInvalida(int opcion)
    {
        return opcion < 1 || opcion > nOpciones;
    }
}
