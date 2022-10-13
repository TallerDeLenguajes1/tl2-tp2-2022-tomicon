// See https://aka.ms/new-console-template for more information
public static class HelperDeArchivos
{
    static public void escribirContenido(Alumno al){

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
    
}