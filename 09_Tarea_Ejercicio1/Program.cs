/*
Clase 9: Tarea - Ejercicio 1
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:
1) Pedir al usuario la longitud de un vector.
2) Crear el vector del tamaño ingresado.
3) Llenar el mismo con datos aleatorios.
4) Mostrar el vector por pantalla.
5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. 
En otras palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, 
una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10. 
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio.
6) Mostrar el vector nuevamente.
*/

Console.Clear();

Console.WriteLine("Ingrese la longitud del vector: ");

int longitud = int.Parse(Console.ReadLine());

int[] vector = new int[longitud];

Random aleatorio = new Random();

for (int i = 0; i < vector.Length; i++) {
    vector[i] = aleatorio.Next(100);
}

int contador = 0;

foreach (int i in vector) {
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}

Console.WriteLine();

int numero = longitud / 2;

contador = 0;

for (int i = longitud; i > numero; i--) {
    int aux1 = vector[i - 1];
    int aux2 = vector[contador];
    vector[i - 1] = aux2;
    vector[contador] = aux1;
    contador++;
}

contador = 0;

foreach (int i in vector) {
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}

Console.WriteLine("\nPrograma finalizado correctamente");