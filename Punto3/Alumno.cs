// See https://aka.ms/new-console-template for more information
public class Alumno
{
private int Id { get; set; }
private string Nombre { get; set; }
private string Apellido { get; set; }
private int Dni { get; set; }
public int Curso { get; set; }

    public Alumno()
    {
    }

    public Alumno(int id, string nombre, string apellido, int dni, int curso)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        Curso = curso;
    }

    public string lineaCSV(){
        return $"{Id};{Nombre};{Apellido};{Dni}";
    }
}
