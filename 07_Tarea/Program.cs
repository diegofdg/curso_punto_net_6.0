Console.Clear();

int[] numeros = new int[10];

// Pedimos al usuario que ingrese 10 números
for (int i = 0; i < 10; i++) {
    Console.WriteLine($"Ingrese el número: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());    
}

int suma = 0;

for (int i = 0; i < 10; i++) {
    suma = suma + numeros[i];
}

int mayor = numeros[0];
for (int i = 0; i < 10; i++) {
    if (numeros[i] > mayor) {
        mayor = numeros[i];
    }
}

int menor = numeros[0];
for (int i = 0; i < 10; i++) {
    if (numeros[i] < menor) {
        menor = numeros[i];
    }
}

double promedio = suma / 10d;

Console.WriteLine("Los números ingresados son: ");
for (int i = 0; i < 10; i++) {
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("");
Console.WriteLine($"La suma es: {suma}");
Console.WriteLine($"El menor es: {menor}");
Console.WriteLine($"El mayor es: {mayor}");
Console.WriteLine($"El promedio es: {promedio}");