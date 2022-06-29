/*
Ejercicio de cartas españolas orientado a objetos:

Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo
(espadas, bastos, oros y copas).
La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

Las operaciones que podrá realizar la baraja son:

Barajar():
  Cambia de posición todas las cartas aleatoriamente.

SiguienteCarta():
  Devuelve la siguiente carta que está en la baraja, cuando no haya más
  o se haya llegado al final, se indica al usuario que no hay más cartas.

CartasDisponibles():
  Indica el número de cartas que aún puede repartir

DarCartas(int cantidad):
  Dado un número de cartas que nos pidan, le devolveremos ese número de
  cartas (piensa que puedes devolver). En caso de que haya menos cartas
  que las pedidas, no devolveremos nada pero debemos indicárselo al
  usuario.

CartasMonton():
  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna
  indicárselo al usuario.

MostrarBaraja():
  Muestra todas las cartas hasta el final. Es decir, si se saca una
  carta y luego se llama al método, este no mostrara esa primera carta.


Escribir un programa que dentro de un bucle vaya mostrando las opciones
que querramos, por ejemplo

1 - Barajar
2 - Mostrar siguiente carta
3 - Mostrar cartas disponibles
4 - Dar cartas
5 - Mostrar cartas del monton
6 - Mostrar baraja
7 - Salir
*/

using _14_Tarea.Modelo;

Console.Clear();

int opcionMenu;
int contador = 0;
int posicion = 0;
int siguientePosicion = 0;

Console.WriteLine("¡Bienvenido al juego de Cartas Españolas!!!");
Baraja baraja = new Baraja();
Array mazo = baraja.MezclarCartas();

do {
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    
    opcionMenu = int.Parse(Console.ReadLine());    

    switch (opcionMenu) {
        case 1:
            mazo = baraja.MezclarCartas();
            contador = 0;
            Console.WriteLine("Las cartas han sido mezcladas");
            break;

        case 2:
            if (contador == 0) {
                posicion = 0;
            } else {
                posicion = siguientePosicion;
            }
            Console.WriteLine($"La siguiente carta es el: { baraja.SiguienteCarta(mazo, posicion, out siguientePosicion) }");
            posicion = siguientePosicion;
            contador++;
            break;

        case 3:
            if (contador == 0) {
                posicion = 0;
            } else {
                posicion = siguientePosicion;
            }
            Console.WriteLine($"La cantidad de cartas disponibles son: { baraja.CartasDisponibles(mazo, posicion) }");
            break;

        case 4:
            int cantidad = 0;
            Array mano;

            if (contador == 0) {
                posicion = 0;
            }
            else {
                posicion = siguientePosicion;
            }
            
            Console.Write("Cuantas cartas desea repartir?");
            cantidad = int.Parse(Console.ReadLine());

            mano = baraja.DarCartas(mazo, posicion, cantidad, out siguientePosicion);
            posicion = siguientePosicion;
            contador += cantidad;

            Console.Write("Las cartas repartidas son: ");
            foreach (string carta in mano) {
                Console.Write($"| {carta} ");
            }
            Console.Write("|");
            break;

        case 5:
            Array monton;
            if (contador == 0) {
                posicion = 0;
            }
            else {
                posicion = siguientePosicion;
            }
            
            monton = baraja.CartasMonton(mazo, posicion);
            foreach (string i in monton) {
                Console.Write($"| {i} ");
            }
            Console.Write("|");
            break;

        case 6:
            Array mostrarBaraja;
            if (contador == 0) {
                posicion = 0;
            } else {
                posicion = siguientePosicion;
            }
            
            mostrarBaraja = baraja.MostrarBaraja(mazo, posicion);
            Console.Write("- Las cartas restantes son: ");
            foreach (string i in mostrarBaraja) {
                Console.Write($"| {i} ");
            }
            Console.Write("|");
            break;

        case 7:
            Console.WriteLine("\nPrograma finalizado correctamente");
            break;

        default:
            Console.WriteLine("Opción incorrecta, vuelva a intentarlo");
            break;
    }    

} while (opcionMenu != 7);