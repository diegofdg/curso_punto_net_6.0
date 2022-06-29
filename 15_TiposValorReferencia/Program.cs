/*
int primerNumero = 1986;
int segundoNumero = primerNumero;

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);

primerNumero = 1978;

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);
*/

/*

using _15_TiposValorReferencia.Modelos;

var miPrimerClase = new MiClase {
    Id = 1,
    Nombre = "Juancito Perez"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miSegundaClase.Nombre);

miPrimerClase.Nombre = "Andres Gomez";

Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);

*/

/*

using _15_TiposValorReferencia.Modelos;

var miPrimerClase = new MiClase {
    Id = 1,
    Nombre = "PEPE"
};

var miSegundaClase = new MiClase {
    Id = 2,
    Nombre = "QUINO"
};

var miLista = new List<MiClase>();
miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);

Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);

foreach (var item in miLista) {
    Console.WriteLine(item.Nombre);
    if (item.Id == 1) {
        item.Nombre = "ROBERTO";
    }
}

Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);

*/

using _15_TiposValorReferencia.Modelos;

var primeraPersona = new Persona {
    Apellido = "Mateos",
    Nombre = "Joaquin"
};

var primerDocente = new Docente {
    Salario = 70000,
    Apellido = "Juan Pablo",
    Nombre = "Ferreyra"
};

var primerAlumno = new Alumno {
    Legajo = 1234,
    Apellido = "Rodriguez",
    Nombre = "Ricardo"
};

var personas = new List<Persona>();
personas.Add(primeraPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach (var persona in personas) {
    if (persona.GetType() == typeof(Docente)) {
        var docente = (Docente)persona;
        Console.WriteLine(docente.Salario);
    }
};