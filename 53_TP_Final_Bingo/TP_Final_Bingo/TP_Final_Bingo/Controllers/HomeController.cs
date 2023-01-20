using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using TP_Final_Bingo.Context;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult HandleClickButton() 
        {
            // Prueba de consulta a la base de datos
            var ctx = new BingoContext();
            var historial = ctx.HistorialBolilleros.Select(selector => new { Id = selector.Id, Fecha = selector.FechaHora });
            foreach (var item in historial)
            {
                Console.WriteLine($"{item.Id} - {item.Fecha}");
            }

            return View("Index", carton);
        }
    }
}