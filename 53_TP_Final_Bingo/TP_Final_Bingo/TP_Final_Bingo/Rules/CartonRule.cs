using System.Collections.Generic;
using System.Reflection;

namespace TP_Final_Bingo.Rules
{
    public class CartonRule
    {
        public List<int> CrearCartones()
        {
            var cartonEnLista = new List<int>();

            List<int> carton = CrearCarton();

            cartonEnLista.AddRange(carton);

            return cartonEnLista;
        }

        public List<int> CrearCarton()
        {
            var genRandom = new Random(DateTime.Now.Millisecond);

            var carton = new int[3, 9];

            var cartonEnLista = new List<int>();

            // Generamos 4 cartones
            for (int i = 0; i < 4; i++)
            {
                // Generamos los números para el cartón
                for (int c = 0; c < 9; c++)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        int nuevoNumero = 0;
                        bool encontreUnoNuevo = false;
                        while (!encontreUnoNuevo)
                        {
                            if (c == 0)
                            {  // columna 1
                                nuevoNumero = genRandom.Next(1, 10);  // Genera números del 1 al 9
                            }
                            else if (c == 8)
                            {  // columa 9
                                nuevoNumero = genRandom.Next(80, 91); // Genera números del 80 al 90
                            }
                            else
                            { // todas las demás columnas
                                nuevoNumero = genRandom.Next(c * 10, c * 10 + 10);  // Genera números del 10 al 19, del 20 al 29, etc
                            }

                            // Buscamos si el nuevo número existe en la columna
                            encontreUnoNuevo = true;
                            for (int f2 = 0; f2 < 3; f2++)
                            {
                                if (carton[f2, c] == nuevoNumero)
                                {
                                    encontreUnoNuevo = false;
                                    break;
                                }
                            }
                            // Si salio del bucle y no encontro repetidos,
                            // encontreUnoNuevo = true y sale del bucle while                
                        }
                        carton[f, c] = nuevoNumero;
                    }
                }

                // Ordenamos las columnas
                for (int c = 0; c < 9; c++)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        for (int k = f + 1; k < 3; k++)
                        {
                            if (carton[f, c] > carton[k, c])
                            {
                                int aux = carton[f, c];
                                carton[f, c] = carton[k, c];
                                carton[k, c] = aux;
                            }
                        }
                    }
                }

                var borrados = 0;
                while (borrados < 12)
                {
                    var filaABorrar = genRandom.Next(0, 3);
                    var columnaABorrar = genRandom.Next(0, 9);

                    if (carton[filaABorrar, columnaABorrar] == 0)
                    {
                        continue;
                    }

                    // Contamos cuantos ceros hay en esta fila
                    var cerosEnFila = 0;
                    for (int c = 0; c < 9; c++)
                    {
                        if (carton[filaABorrar, c] == 0)
                        {
                            cerosEnFila++;
                        }
                    }

                    // Contamos cuantos ceros hay en columna
                    var cerosEnColumna = 0;
                    for (int f = 0; f < 3; f++)
                    {
                        if (carton[f, columnaABorrar] == 0)
                        {
                            cerosEnColumna++;
                        }
                    }

                    // Contamos cuantos items tenemos en cada columna
                    var itemsPorColumna = new int[9];
                    for (int c = 0; c < 9; c++)
                    {
                        for (int f = 0; f < 3; f++)
                        {
                            if (carton[f, c] != 0)
                            {
                                itemsPorColumna[c]++;
                            }
                        }
                    }

                    // Contamos cuantas columnas hay con un solo número
                    var columnasConUnSoloNumero = 0;
                    for (int c = 0; c < 9; c++)
                    {
                        if (itemsPorColumna[c] == 1)
                        {
                            columnasConUnSoloNumero++;
                        }
                    }

                    // Si ya hay 4 ceros en la fila o si ya hay 2 ceros en la columna,
                    // no hago nada
                    if (cerosEnFila == 4 || cerosEnColumna == 2)
                    {
                        continue;
                    }

                    // Si hay 3 columnas con 1 solo número, a partir de ahora debo borrar solo las columnas
                    // que tienen 3 items
                    if (columnasConUnSoloNumero == 3 && itemsPorColumna[columnaABorrar] != 3)
                    {
                        continue;
                    }

                    // Si no entro por las opciones anteriores, borramos el número
                    carton[filaABorrar, columnaABorrar] = 0;
                    borrados++;
                }

                // Trasponemos el carton cambiando las filas por las columnas
                var cartonTraspuesto = new int[9, 3];

                for (var c = 0; c < 3; c++)
                {
                    for (var f = 0; f < 9; f++)
                    {
                        cartonTraspuesto[f, c] = carton[c, f];
                    }
                }

                // Agregamos el carton traspuesto a la lista de numeros
                for (var fila = 0; fila < 3; fila++)
                {
                    for (var columna = 0; columna < 9; columna++)
                    {
                        cartonEnLista.Add(cartonTraspuesto[columna, fila]);
                    }
                }
            }

            return cartonEnLista;
        }
    }
}
