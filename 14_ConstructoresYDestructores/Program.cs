using _14_ConstructoresYDestructores;

/*
Persona p = null;

for (int i = 0; i < 10000; i++) {
    p = new Persona();
}

Console.WriteLine(p.nombre + " " + p.apellido);
*/

var personas = new List<Persona>();

for (int i = 0; i < 10000; i++) {
    var p = new Persona();
    personas.Add(p);
}

Console.WriteLine("Pulse una tecla para continuar");
Console.ReadLine();

Persona.saludar();