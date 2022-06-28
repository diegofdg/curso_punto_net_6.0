using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia.Colegio {
    public class Persona {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }

        public Persona() {
            NombreCompleto = "Juan Perez";
            Dni = 22200222;
        }

        protected string Clave() {
            return "0134589fjdsañljf";

        }
    }
}