using TP_Final_Bingo.Context;
using TP_Final_Bingo.Controllers;
using TP_Final_Bingo.Models;

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

        public string GuardarBolilla(HistorialBolillero historialBolillero)
        {
            var ctx = new BingoContext();
            var bolilla = new HistorialBolillero
            {
                Numero = historialBolillero.Numero,
                FechaHora = historialBolillero.FechaHora
            };

            ctx.Add(bolilla);
            try
            {
                var respuesta = ctx.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                var respuesta = ex.Message;
                return respuesta;
            }            
        }
    }
}
