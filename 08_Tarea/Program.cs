/*
Clase 8: Tarea - Crear un programa que cumpla con los siguientes pasos
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimensión (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.Clear();
Console.Write("Ingrese la cantidad de columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas];
double[] promedios = new double[cantidadColumnas];

for (int columna = 0; columna < cantidadColumnas; columna++) {
    Console.WriteLine();
    Console.WriteLine($"Ingrese los valores de la columna Nº {columna + 1}: ");
    int suma = 0;

    for (int fila = 0; fila < cantidadFilas; fila++) {
        if (fila == cantidadFilas - 1) {
            Console.Write($"Fila Nº {fila + 1}: ");
            numeros[fila, columna] = int.Parse(Console.ReadLine());
            suma += numeros[fila, columna];
            promedios[columna] = suma / cantidadFilas;
        } else {
            Console.Write($"Fila Nº {fila + 1}: ");
            numeros[fila, columna] = int.Parse(Console.ReadLine());
            suma += numeros[fila, columna];
        }        
    }
}

Console.WriteLine();
Console.WriteLine($"Los valores ingresados son: ");

for (int columna = 0; columna < cantidadColumnas; columna++) {    
    Console.WriteLine($"Columna Nº {columna + 1}: ");

    for (int fila = 0; fila < cantidadFilas; fila++) {
        Console.Write($"Fila Nº {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);
        if (fila == cantidadFilas - 1) {
            Console.WriteLine();
        }
    }
}

for (int i = 0; i < cantidadColumnas; i++) {    
    Console.WriteLine($"Promedio de la columna Nº {i + 1}: = {promedios[i]}");
}

Console.WriteLine("\nPrograma finalizado correctamente");