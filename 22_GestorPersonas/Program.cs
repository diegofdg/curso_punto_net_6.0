using _22_GestorPersonas.Frontend;
using _22_GestorPersonas.Repositorio;
using _22_GestorPersonas.Modelo;

//Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//Insertar personas en una base de datos, mostrar datos de una determinada persona o
//de todas las personas.


// Ingrese 1 para trabajar sobre Persona
// Ingrese 2 para trabajar sobre Desempleado

new MenuAplicacionPersona(new RepositorioEnArchivos<Persona>()).Iniciar();

// new MenuAplicacionDesempleado(new RepositorioEnArchivos<Desempleado>()).Iniciar();