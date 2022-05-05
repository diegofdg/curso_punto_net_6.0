/****** Ejemplo de condicional if ******/

Console.Write("Ingrese su edad: "); // Le pedimos al usuario que ingrese su edad
int edad = int.Parse(Console.ReadLine()); // Obtenemos la edad por teclado

Console.Write("Ingrese su equipo de fútbol: "); // Le pedimos al usuario que ingrese su edad
string equipo = Console.ReadLine();

Console.WriteLine("La edad ingresada es: " + edad);

/*
    AND -> && (Y)
    OR  -> || (O)
    IGUAL QUE -> ==
    DISTINTO QUE -> !=
 */

bool condicion = edad < 18 && equipo == "River";

// Evaluamos la edad y el equipo
if (condicion) {
    // Instrucciones si se cumple la condición evaluada
    Console.WriteLine("Usted es menor de edad o es de River.");
    Console.WriteLine("Prohibida la entrada");
} else {
    // Instrucciones si no se cumple la condición evaluada
    Console.WriteLine("Usted es mayor de edad o no es de River.");
}


/****** Ejemplo de condicional if else ******/

Console.Write("Ingrese la edad: ");
int edad2 = int.Parse(Console.ReadLine());

if (edad2 < 0) {
    Console.WriteLine("La edad no es válida. Ingrese un valor no negativo");
} else if (edad2 < 14) {
    Console.WriteLine("Va a la primaria");
} else if (edad2 < 18) {
    Console.WriteLine("Va al secundario");
} else if (edad2 < 28) {
    Console.WriteLine("Va a la facultad");
} else {
    Console.WriteLine("A trabajar no queda otra");
}


/****** Ejemplo del switch ******/

Console.WriteLine("Ingrese el primer número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");

Console.WriteLine("Ingrese la operación a realizar: ");
string operacion = Console.ReadLine();

double resultado = 0;

switch (operacion) {
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0:
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingresó una opción no válida");
        break;
}

Console.WriteLine("El resultado es: " + resultado);