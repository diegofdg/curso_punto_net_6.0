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

        public HomeController(ILogger<HomeController> logger, ICartonService cartonService)
        {
            _logger = logger;
            _cartonService = cartonService;
        }

        public IActionResult Index()
        {
            var carton = _cartonService.CrearCartones();
            return View(carton);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}