Console.WriteLine("Ingrese cantidad de numeros primos deseados:");
int n = int.Parse(Console.ReadLine());

int[] primos = new int[n];
// List<int> primos2 = new List<int>();

int posicion = 0;
int numero = 1;

while (posicion < n) {
    int aux = 0;
    for (int i = 1; i <= numero; i++) {
        if (numero % i == 0) {
            aux++;
        }
    }
    if (aux == 2) {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;
}
foreach (int i in primos) {
    Console.WriteLine(i);
}
Console.WriteLine("Pulse una tecla para finalizar");
Console.ReadKey();