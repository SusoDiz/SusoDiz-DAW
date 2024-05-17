public class HojaCalculo
{
    public static String[,] datos(string nameFile)
    {
        String? line;
        List<List<String>> datosLista;
        String[,] datos;
        String directorioBase;
        String pathFile;
        directorioBase = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            + Path.DirectorySeparatorChar + "Documents" + Path.DirectorySeparatorChar;
        pathFile = directorioBase + nameFile;
        StreamReader? myfile = new(pathFile, System.Text.Encoding.Default);
        if (myfile == null)
            throw new IOException("No se pudo leer el fichero " + pathFile);

        datosLista = new List<List<String>>();
        while ((line = myfile.ReadLine()) != null)
        {
            if (line != "")
            {
                datosLista.Add(line.Split(';').ToList());
            }
        }
        myfile.Close();
        datos = new String[datosLista.Count, datosLista[0].Count];
        for (int i = 0; i < datosLista.Count; i++)
            for (int j = 0; j < datosLista[i].Count; j++)
                datos[i, j] = datosLista[i][j];
        return datos;
    }
}