string respuesta = "S";

while (respuesta.ToUpper() == "S") {

    // 1) Borrar la pantalla.
    Console.Clear();

    //2) Pedir el nombre de una persona.
    Console.WriteLine("Ingrese su nombre: ");
    string nombre = Console.ReadLine();

    //3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
    Console.Write($"Hola {nombre} ");

    //4) Preguntar si se quiere continuar.
    Console.WriteLine("¿Desea continuar? (S/N)");
    respuesta = Console.ReadLine();

    if (respuesta.ToUpper() != "S") {
        if (respuesta.ToUpper() != "N") {
            // 7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
            Console.WriteLine("Opción no válida");
        } else {
            // 6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
            Console.WriteLine("Programa finalizado correctamente");
        }
    } // 5) Si la respuesta es "S" repetir desde el punto 1.
}