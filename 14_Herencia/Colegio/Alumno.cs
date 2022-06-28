using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia.Colegio {
    public class Alumno : Persona {
        public String Curso { get; set; }
        public int Division { get; set; }
        public string RecuperaClave() {
            return Clave();
        }
    }
}