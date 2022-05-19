/*
Clase 7: Tarea - Escribe un programa que:
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto. 
 */

float[] numeros = new float[10];
float suma = 0;

for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine($"Por favor ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];
}

Console.Clear();

float minimo = numeros[0];
float maximo = numeros[0];

for (int i = 0; i < numeros.Length; i++) {
    if(numeros[i] < minimo) {
        minimo = numeros[i];
    } else if (numeros[i] > maximo) {
        maximo = numeros[i];
    }    
}

float promedio = suma / numeros.Length;


Console.Write("Los números ingresados son: ");
for (int i = 0; i < numeros.Length; i++) {
    if (i == numeros.Length - 1) {
        Console.WriteLine(numeros[i]);
    } else {
        Console.Write($"{numeros[i]}, ");
    }
}

Console.WriteLine($"La suma de todos los valores ingresados es: {minimo}");
Console.WriteLine($"El mínimo valor ingresado es: {minimo}");
Console.WriteLine($"El máximo valor ingresado es: {maximo}");
Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");

Console.WriteLine("\nPrograma finalizado correctamente");