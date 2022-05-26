/*
Clase 9: Tarea - Ejercicio 2
Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla:
1) Cartón de 3 filas por 9 columnas
2) El cartón debe tener 15 números y 12 espacios en blanco
3) Cada fila debe tener 5 números
4) Cada columna debe tener 1 o 2 números
5) Ningún número puede repetirse
6) La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, 
la tercera del 20 al 29, así sucesivamente hasta la última columna la cual 
contiene del 80 al 90
7) Mostrar el carton por pantalla
*/

Console.Clear();

int[,] carton = new int[3, 9];

int cantidadFilas = carton.GetUpperBound(0) + 1;

int cantidadColumnas = carton.GetUpperBound(1) + 1;

for (int columna = 0; columna < cantidadColumnas; columna++) {
    Random aleatorio = new Random();
    int cantidadPorFila = aleatorio.Next(1, 3);
    int[] auxiliar = new int[cantidadPorFila];
    int contador = 0;
    int minimo = 0;
    int maximo = 0;

    switch (columna) {
        case 0:
            minimo = 1;
            maximo = 9;
            break;
        case 1:
            minimo = 10;
            maximo = 19;
            break;
        case 2:
            minimo = 20;
            maximo = 29;
            break;
        case 3:
            minimo = 30;
            maximo = 39;
            break;
        case 4:
            minimo = 40;
            maximo = 49;
            break;
        case 5:
            minimo = 50;
            maximo = 59;
            break;
        case 6:
            minimo = 60;
            maximo = 69;
            break;
        case 7:
            minimo = 70;
            maximo = 79;
            break;
        case 8:
            minimo = 80;
            maximo = 90;
            break;
    }

    while (contador < cantidadPorFila) {
        int numeroAleatorio = aleatorio.Next(minimo, maximo);
        bool repetido = false;
        for (int i = 0; i < cantidadPorFila; i++) {
            if (auxiliar[i] == numeroAleatorio) {
                repetido = true;
                break;
            }
        }

        if (!repetido) {
            auxiliar[contador] = numeroAleatorio;
            carton[contador, columna] = numeroAleatorio;
            contador++;
        }
    }
}

for (int columna = 0; columna < cantidadColumnas; columna++) {
    Console.WriteLine();

    Console.WriteLine($"Columna N°: {columna + 1}: ");

    for (int fila = 0; fila < cantidadFilas; fila++) {
        Console.Write($"Valor número {fila + 1}: ");

        Console.WriteLine(carton[fila, columna]);
    }
}

Console.WriteLine("\nPrograma finalizado correctamente");