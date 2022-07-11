using _21_LinQ_y_QueryExpression;

// Ejemplo 1
Console.WriteLine("\nEjemplo 1 - Array");
int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int todosLosNumeros = numeros.Count();
Console.WriteLine(todosLosNumeros);

int numerosImpares = numeros.Count(n => n % 2 == 1);

numerosImpares = numeros.Count(n => {
    return n % 2 == 1;
});
Console.WriteLine(numerosImpares);


// Ejemplo 2
Console.WriteLine("\nEjemplo 2 - Lambda Expressions");
var misClientes = new List<Cliente>();
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Cliente { Apellido = "De Tal", Nombre = "Fulano" });

IEnumerable<Cliente> juanes = misClientes.Where( cadaCliente => cadaCliente.Nombre == "Juan");

/*
var juanes = misClientes.Where(cadaCliente => {
    if (cadaCliente.Nombre == "Juan")
        return true;
    else
        return false;
});
*/

foreach (Cliente c in juanes) {
    string n = c.Nombre;
    Console.WriteLine(n);
}

// Query Expression
// Ejemplo 3
// Fuente de datos
Console.WriteLine("\nEjemplo 3 - Query Expression");
int[] puntajes = { 90, 71, 82, 93, 75, 82 };

IEnumerable<int> resultados =
    from puntaje in puntajes
    where puntaje > 80
    orderby puntaje descending
    select puntaje;

foreach (var r in resultados) {
    //Console.WriteLine(r);
}

var resultado2 =
    from cliente in misClientes
    where cliente.Nombre == "Juan"
    orderby cliente.Nombre descending
    select new { cliente.Nombre };


foreach (var c in resultado2) {
    Console.WriteLine(c);
}