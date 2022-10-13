// See https://aka.ms/new-console-template for more information
using NLog;
Console.WriteLine("Hello, World!");

Logger logger = LogManager.GetCurrentClassLogger();
System.Console.WriteLine("Cuantos alumnos quiere ingresar?");
int cantAlumnos= Convert.ToInt32(Console.ReadLine());
List<Alumno> listaAlumnos= new List<Alumno>();
int id, dni, curso;
string apellido, nombre;
for (int i = 0; i < cantAlumnos; i++)
{
    try
    {
        System.Console.WriteLine($"Alumno nro{i+1}");
        System.Console.WriteLine("Dni: ");
        dni= Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Id: ");
        id= Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Nombre: ");
        nombre= Console.ReadLine();
        System.Console.WriteLine("Apellido:");
        apellido= Console.ReadLine();
        System.Console.WriteLine("Curso:");
        curso= Convert.ToInt32(Console.ReadLine());
        Alumno alum = new Alumno(id, nombre, apellido, dni, curso);
        listaAlumnos.Add(alum);
    }
    catch (NullReferenceException e) 
    {
        logger.Error($"Error: {e.Message} stack trace: {e.StackTrace}");
    }
    finally
    {
        logger.Info("Se termino la carga de datos");
    }

}
foreach (var alumno in listaAlumnos)
{
    HelperDeArchivos.escribirContenido(alumno);    
}
