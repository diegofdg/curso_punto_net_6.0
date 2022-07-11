using _22_GestorPersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_GestorPersonas.Interfaces
{
    public interface IRepositorio<T> where T : Persona
    {
        void Insertar(T persona);

        void Eliminar(string numeroDocumento);

        void Actualizar(T persona);

        void Actualizar(string numeroDocumento, string nombre, string apellido);

        bool Existe(string numeroDocumento);

        bool Existe(T persona);
    }
}