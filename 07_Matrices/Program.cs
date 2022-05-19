/*
string[] Cars = { "Ford", "Fiat", "BMW", "Toyota" };

Console.WriteLine(Cars[0]);

string[] frutas = new string[4];

frutas[0] = "Pera";
frutas[1] = "Manzana";
frutas[2] = "Banana";
frutas[3] = "Kiwi";

// frutas[4] = "Naranja";

Console.WriteLine(frutas[2]);
Console.WriteLine(frutas[3]);
Console.WriteLine("");
Console.WriteLine(frutas[4]);
*/

int[] numeros = new int[5];

/*
Console.WriteLine($"el array tine tantas posiciones: {numeros.Length} ");
Console.WriteLine("por favor ingrese numeros");
numeros[0] = int.Parse(Console.ReadLine());
numeros[1] = int.Parse(Console.ReadLine());
numeros[2] = int.Parse(Console.ReadLine());
numeros[3] = int.Parse(Console.ReadLine());
numeros[4] = int.Parse(Console.ReadLine());
*/


for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine($"Por favor ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;

for (int i = 0; i < numeros.Length; i++) {
    // suma = suma + numeros[i];
    suma += numeros[i];
}

Console.WriteLine($"El valor de la suma es = {suma}");

Console.WriteLine("Los valores ingresados son: ");

for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine(numeros[i]);
}