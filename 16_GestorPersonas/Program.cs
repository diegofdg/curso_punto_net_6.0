using _16_GestorPersonas.Modelo;
using _16_GestorPersonas.Repositorio;

//Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//Insertar personas en una base de datos, mostrar datos de una determinada persona o
//de todas las personas.

var repositorio = new RepositorioDePersonas();

//Le pido al usuario los datos de una persona para agregar
//El usuario debería elegir el tipo de persona a agregar

var usuarioNombre = "Ezequiel";
var usuarioApellido = "Etchecoin";

repositorio.Insertar(new Desempleado {
    Nombre = usuarioNombre,
    Apellido = usuarioApellido
});