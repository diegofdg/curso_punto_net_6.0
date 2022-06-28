using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ConstructoresYDestructores {
    internal class Persona {
        public Persona() {
            nombre = "Juan";
            apellido = "Perez";
        }

        public String nombre;
        public String apellido;

        public static void saludar() {
            Console.WriteLine("Hola desde un método estático");
        }
    }
}
