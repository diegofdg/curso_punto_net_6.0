using TP_Final_Bingo.Controllers;

namespace TP_Final_Bingo.Services
{
    public class CartonService : ICartonService
    {
        public List<int> CrearCartones()
        {
            var logica = new CartonLogica();
            var carton = logica.CrearCartones();
            return carton;
        }

        public int LanzarBolilla()
        {
            var logica = new CartonLogica();
            var bolilla = logica.LanzarBolilla();
            return bolilla;
        }
    }
}
