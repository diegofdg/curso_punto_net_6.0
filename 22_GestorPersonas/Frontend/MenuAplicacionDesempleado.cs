using _22_GestorPersonas.Interfaces;
using _22_GestorPersonas.Modelo;
using _22_GestorPersonas.Repositorio;

namespace _22_GestorPersonas.Frontend
{
    public class MenuAplicacionDesempleado
    {
        private IRepositorio<Desempleado> _repositorio;

        public MenuAplicacionDesempleado(IRepositorio<Desempleado> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Iniciar()
        {

        }
    }
}
