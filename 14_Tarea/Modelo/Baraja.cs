using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tarea.Modelo {
    internal class Baraja {
        public Array Basto { get; set; }
        public Array Copa { get; set; }
        public Array Espada { get; set; }
        public Array Oro { get; set; }

        public Array CrearPalo() {
            int[] palo = new int[10];
            for (int i = 0; i < palo.Length; i++) {
                if (i < 7) {
                    palo[i] = i + 1;
                } else {
                    palo[i] = i + 3;
                }                
            }
            return palo;
        }

        public Array MezclarCartas() {
            string[] mazo = new string[40];

            Basto = CrearPalo();
            Copa = CrearPalo();
            Espada = CrearPalo();
            Oro = CrearPalo();

            Random aleatorio = new Random();

            int contador = 0;

            for (int i = 0; i < mazo.Length; i++) {
                int posicion = aleatorio.Next(0, 40);

                while (mazo[posicion] != null) {
                    posicion = aleatorio.Next(0, 40);
                }

                if (contador == 10) {
                    contador = 0;
                }

                if (i < 10) {
                    mazo[posicion] = $"{ (int) Basto.GetValue(contador) } DE BASTO";
                    contador++;
                } else if (i > 9 && i < 20) {
                    mazo[posicion] = $"{ (int) Oro.GetValue(contador) } DE ORO";
                    contador++;
                } else if (i > 19 && i < 30) {
                    mazo[posicion] = $"{ (int) Espada.GetValue(contador) } DE ESPADA";
                    contador++;
                } else if (i > 29 && i < 40) {
                    mazo[posicion] = $"{ (int) Copa.GetValue(contador) } DE COPA";
                    contador++;
                }
            }
            return mazo;
        }

        public string SiguienteCarta(Array maso, int posicion, out int siguientePosicion) {
            Array baraja = maso;
            string siguienteCarta = baraja.GetValue(posicion).ToString();
            siguientePosicion = posicion + 1;
            return siguienteCarta;
        }

        public int CartasDisponibles(Array maso, int posicion) {
            int cantidad = 0;
            Array baraja = maso;
            cantidad = baraja.Length - posicion;
            return cantidad;
        }

        public Array DarCartas(Array maso, int posicion, int cantidadCartas, out int siguiente) {
            Array baraja = maso;
            int cantidad = cantidadCartas;
            string [] cartas = new string[cantidad];

            for (int i = 0; i < cartas.Length; i++) {
                cartas[i] = baraja.GetValue(posicion).ToString();
                posicion++;
            }
            siguiente = posicion;

            return cartas;
        }

        public Array CartasMonton(Array maso, int posicion) {
            string [] monton = new string[posicion];

            if (posicion == 0) {
                Console.WriteLine("No hay cartas en el montón");
            } else {
                for (int i = 0; i < monton.Length; i++) {
                    monton[i] = maso.GetValue(i).ToString();
                }
            }
            return monton;
        }

        public Array MostrarBaraja(Array maso, int posicion) {
            string [] barajaMostrar = new string[maso.Length - posicion];
            for (int i = 0; i < barajaMostrar.Length; i++) {
                barajaMostrar[i] = (string)maso.GetValue(i + posicion);
            }
            return barajaMostrar;
        }
    }
}