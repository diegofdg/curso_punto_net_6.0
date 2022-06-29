using _16_GestorPersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_GestorPersonas.Repositorio {
    public class RepositorioDePersonas {
        public List<Persona> Personas { get; set; }

        public RepositorioDePersonas() {
            Personas = new List<Persona>();
        }

        public void Insertar(Persona persona) {
            Personas.Add(persona);
        }
        public void Eliminar(string numeroDocumento) {
            //Definir como eliminar una persona de la Lista de Personas.
        }

        public void Actualizar(Persona persona) {
            foreach (var personaActual in Personas) {
                if (personaActual.NumeroDeDocumento == persona.NumeroDeDocumento) {
                    personaActual.Nombre = persona.Nombre;
                    personaActual.Apellido = persona.Apellido;
                    personaActual.FechaNacimiento = persona.FechaNacimiento;
                }
            }
        }
        public void Actualizar(string numeroDocumento, string nombre, string apellido) {
            foreach (var personaActual in Personas) {
                if (personaActual.NumeroDeDocumento == numeroDocumento) {
                    personaActual.Nombre = nombre;
                    personaActual.Apellido = apellido;
                }
            }
        }
    }
}