using _21_GestorPersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_GestorPersonas.Interfaces
{
    public interface IRepositorioPersona
    {
        void Insertar(Persona persona);

        void Eliminar(string numeroDocumento);

        void Actualizar(Persona persona);

        void Actualizar(string numeroDocumento, string nombre, string apellido);

        bool Existe(string numeroDocumento);

        bool Existe(Persona persona);
    }
}