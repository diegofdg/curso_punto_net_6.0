/*
Diseñe la siguiente jerarquía para las clases:
- Cuadrilátero.
- Trapecio.
- Rectángulo.
- Cuadrado.

Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.

Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices
de la figura y debe contener un método abstracto para calcular el área.

Agregue un constructor a cada clase para inicializar sus datos e invoque el constructor
de la clase base desde el constructor de cada clase derivada.

Escriba un programa que instancie objetos de cada una de las clases y calcule el área
correspondiente. Investigue las fórmulas para calcular el área de cada figura.
*/

using _16_Tarea.Modelo;

Console.Clear();
int[] vertice1 = new int[2];
int[] vertice2 = new int[2];
int[] vertice3 = new int[2];
int[] vertice4 = new int[2];

// Creamos un cuadrado, calculamos su área y luego la mostramos por consola
vertice1[0] = 4;
vertice1[1] = 1;
vertice2[0] = 4;
vertice2[1] = 4;
vertice3[0] = 1;
vertice3[1] = 4;
vertice4[0] = 1;
vertice4[1] = 1;

Cuadrado cuadrado = new Cuadrado(vertice1, vertice2, vertice3, vertice4);
Console.WriteLine($"El area del cuadrado es = {cuadrado.Area()} unidades cuadradas");

// Creamos un rectangulo, calculamos su área y luego la mostramos por consola
vertice1[0] = 5;
vertice1[1] = 1;
vertice2[0] = 5;
vertice2[1] = 4;
vertice3[0] = 1;
vertice3[1] = 4;
vertice4[0] = 1;
vertice4[1] = 1;

Rectangulo rectangulo = new Rectangulo (vertice1, vertice2, vertice3, vertice4);
Console.WriteLine($"El area del rectángulo es = {rectangulo.Area()} unidades cuadradas");

// Creamos un trapecio, calculamos su área y luego la mostramos por consola
vertice1[0] = 9;
vertice1[1] = 1;
vertice2[0] = 6;
vertice2[1] = 4;
vertice3[0] = 3;
vertice3[1] = 4;
vertice4[0] = 1;
vertice4[1] = 1;

Trapecio trapecio = new Trapecio(vertice1, vertice2, vertice3, vertice4);
Console.WriteLine($"El area del trapecio es = {trapecio.Area()} unidades cuadradas");