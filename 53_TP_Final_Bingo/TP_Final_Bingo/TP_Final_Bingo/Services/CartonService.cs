using TP_Final_Bingo.Context;
using TP_Final_Bingo.Models;
using TP_Final_Bingo.Rules;

namespace TP_Final_Bingo.Services
{
    public class CartonService : ICartonService
    {
        public List<int> CrearCartones()
        {
            var cartonRule = new CartonRule();
            var carton = cartonRule.CrearCartones();
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

        public string GuardarCartones(HistorialCartone historialCartones)
        {
            var ctx = new BingoContext();
            var cartones = new HistorialCartone
            {
                FechaHora = historialCartones.FechaHora,
                Carton1 = historialCartones.Carton1,
                Carton2 = historialCartones.Carton2,
                Carton3 = historialCartones.Carton3,
                Carton4 = historialCartones.Carton4,
            };

            ctx.Add(cartones);
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
