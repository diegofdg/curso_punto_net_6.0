using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP_Final_Bingo.Models;
using TP_Final_Bingo.Services;

namespace TP_Final_Bingo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICartonService _cartonService;
        static List<int> carton = new List<int>();

        public HomeController(ILogger<HomeController> logger, ICartonService cartonService)
        {
            _logger = logger;
            _cartonService = cartonService;            
        }

        public IActionResult Index()
        {
            carton = _cartonService.CrearCartones();
            return View(carton);
        }

        [HttpPost]
        public JsonResult HistorialBolillero([FromBody] HistorialBolillero historialBolillero)
        {
            historialBolillero.FechaHora = DateTime.Now;
            var respuesta = _cartonService.GuardarBolilla(historialBolillero);
            if(respuesta == "ok")
            {
                return Json("ok");
            }
            else
            {
                return Json(respuesta);
            }            
        }

        [HttpPost]
        public JsonResult HistorialCartones([FromBody] HistorialCartone historialCartones)
        {
            historialCartones.FechaHora = DateTime.Now;
            var respuesta = _cartonService.GuardarCartones(historialCartones);
            if (respuesta == "ok")
            {
                return Json("ok");
            }
            else
            {
                return Json(respuesta);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}