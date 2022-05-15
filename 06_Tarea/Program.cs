/*
Clase 6: Tarea - Crear un programa para adivinar un numero

1) Generar un número secreto aleatorio de 1 a 20
2) Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.
3) Si el numero ingresado por el usuario es mayor al número secreto, avisarle que es muy grande y que intente de nuevo y que vuelva al paso 2.
4) Si el numero ingresado es menor al número secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.
5) Si el número ingresado coincide con el número secreto, sacar el siguiente mensaje:
"Felicitaciones, has adivinado el número secreto que era: [numeroSecreto]"
"Lo has logrado en [n] intentos!!"
Y finalizar el programa.

Nota: Obviamente hay que hacer un bucle y crear un contador de intentos.
Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.
*/


Console.Clear();

int numero;
int contador = 0;

int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("Ingrese un número e intente adivinar el número secreto: ");

do {
    numero = int.Parse(Console.ReadLine());
    contador++;

    if(numero > numeroSecreto) {
        Console.WriteLine("\nEl número ingresado es mayor que el número secreto, intente nuevamente:");
    } else if (numero < numeroSecreto) {
        Console.WriteLine("\nEl número ingresado es menor que el número secreto, intente nuevamente:");
    } else if (numero == numeroSecreto) {
        Console.WriteLine($"\nFelicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {contador} intentos!!");
    }

} while (numero != numeroSecreto);

Console.WriteLine("\nPrograma finalizado correctamente");