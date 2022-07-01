using _18_AlumnoDocenteEInterfaces.Models;

var alumno = new Alumno()
{
    
    Nombre = "Joaquín",
    Apellido = "Mateos",
    DNI = "12345678",
    Legajo = "1"
};

var docente = new Docente()
{

    Nombre = "Ezequiel",
    Apellido = "Etchecoin",
    DNI = "95345771",
    Horas = 10
};

var listado = new List<IPersona>();
listado.Add(alumno);
listado.Add(docente);

var nuevoListado = ObtenerPersonasByNombre(listado, "Ezequiel");

Console.WriteLine(nuevoListado.Count);


List<IPersona> ObtenerPersonasByNombre(List<IPersona> personas, string nombre)
{
    var nuevaLista = new List<IPersona>();
    foreach (var p in personas)
    {
        if(p.Nombre == nombre)
        {
            nuevaLista.Add(p);
        }
    }
    return nuevaLista;
}

string obtenerDatos(IPersona persona)
{
    var datos = persona.Nombre + " " + persona.Apellido;
    return datos;
}
