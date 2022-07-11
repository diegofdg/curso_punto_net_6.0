using _22_GestorPersonas.Interfaces;
using _22_GestorPersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_GestorPersonas.Repositorio
{
    public class RepositorioEnDictionary<T> : IRepositorio<T> where T : Persona
    {
        //Usamos un diccionario para guardar las personas.
        public Dictionary<string, T> Personas { get; set; }

        public RepositorioEnDictionary()
        {
            Personas = new Dictionary<string, T>();
        }

        public void Insertar(T persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento);
            if (!personaExiste)
            {
                Personas[numeroDocumento] = persona;
            }
        }

        public void Eliminar(string numeroDocumento)
        {
            Personas[numeroDocumento] = null;
        }

        public void Actualizar(T persona)
        {
            var personaAActualizar = Personas[persona.NumeroDeDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            var personaAActualizar = Personas[numeroDocumento];
            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellido = apellido;
            }
        }

        public bool Existe(string numeroDeDocumento)
        {
            return Personas.ContainsKey(numeroDeDocumento);
        }

        public bool Existe(T persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }
    }
}