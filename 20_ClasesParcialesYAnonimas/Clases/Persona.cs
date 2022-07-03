using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ClasesParcialesYAnonimas.Clases
{
    public partial class Persona {
        public Persona() {
        }   

        public Persona(string nombre, string apellido) {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public partial int CaludarEdad();
    }
}