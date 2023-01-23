using TP_Final_Bingo.Models;

namespace TP_Final_Bingo.Services
{
    public interface ICartonService
    {
        List<int> CrearCartones();
        String GuardarBolilla(HistorialBolillero historialBolillero);
    }
}
