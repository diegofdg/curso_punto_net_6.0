// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Constante

const string constanteTexto = "Bienvenidos a mi aplicación de Consola";
Console.WriteLine(constanteTexto);
// Datos numericos

byte numeroByte = 0;
int numeroInteger = 2147483647;
long numeroLong = 9223372036854775807;
double numeroDouble = 200.123456789;
decimal numeroDecimal = 300.12345678910111213987654321m;
float numeroFloat = 400.123456f;

// Datos lógico
bool numeroBoolFalso = false; // 0
bool numeroBoolVerdadero = true; // 1

// Datos texto
string datoString = "Texto de prueba numero uno";

// Instruccion de salida
Console.WriteLine("número byte = " + numeroByte);
Console.WriteLine("número int = " + numeroInteger);
Console.WriteLine("número long = " + numeroLong);
Console.WriteLine("número double = " + numeroDouble);
Console.WriteLine("número decimal = " + numeroDecimal);
Console.WriteLine("número float = " + numeroFloat);

Console.WriteLine("número bool falso = " + numeroBoolFalso);
Console.WriteLine("número bool verdadero = " + numeroBoolVerdadero);

Console.WriteLine("dato string = " + datoString);

// Instrucción de entrada

Console.WriteLine("Ingrese un texto: ");
datoString = Console.ReadLine();
Console.WriteLine("El texto ingresado es: " + datoString);

Console.WriteLine("Ingrese un número: ");
string numeroString = Console.ReadLine();
numeroInteger = Convert.ToInt32(numeroString);
Console.WriteLine("El número ingresado es: " + numeroInteger);