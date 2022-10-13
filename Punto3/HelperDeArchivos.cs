// See https://aka.ms/new-console-template for more information
public static class HelperDeArchivos
{
    static public void escribirContenido(Alumno al){
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        try
        {
            string[] deportes= {"Atletismo", "Voley", "Futbol"};
            string nombreArchivo= deportes[al.Curso];
            bool archivoExiste= File.Exists(nombreArchivo);
            StreamWriter escritor = File.AppendText(nombreArchivo);
            if (!archivoExiste)
            {
                escritor.WriteLine("ID;DNI;Nombre;Apellido;Curso");
            }
            escritor.WriteLine(al.lineaCSV());
            escritor.Close();
        }
        catch (IndexOutOfRangeException e)
        {
            logger.Error("Error: " + e.Message + "stack trace: " + e.StackTrace);
            System.Console.WriteLine("Se quiere acceder a un elemento del arreglo que no existe. Verifique que el atributo curso en la clase Alumno tenga los valores adecuados");
        }
        catch(NullReferenceException e)
        {
            logger.Error("Error: " + e.Message + "stack trace: " + e.StackTrace);
            System.Console.WriteLine("Error: uno de los campos necesarios contiene un null");
        }
        catch (System.Exception e)
        {
            logger.Error("Error: " + e.Message + "stack trace: " + e.StackTrace);
            System.Console.WriteLine("ha ocurrido un error");
        }
    }

    static public void borrarContenido(string path)
    {
        if (Path.GetFileName(path).Split('.')[1] == "csv") File.Delete(path);        
    }
}