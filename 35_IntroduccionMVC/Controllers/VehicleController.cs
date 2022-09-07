using _35_IntroduccionMVC.Data;
using _35_IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _35_IntroduccionMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult New() { 
            return View();
        }

        public IActionResult Index()
        {
            var vehiculos = _dbContext.Vehiculos.ToList();

            /*
            var model = new VehicleListViewModel
            {
                Vehiculos = new List<VehicleListModel>()
            };

            foreach(var vehiculo in vehiculos)
            {
                model.Vehiculos.Add(new VehicleListModel
                {
                    Id = vehiculo.Id,
                    Dominio = vehiculo.Dominio,
                    AnioFabricacion = vehiculo.AnioFabricacion
                });
            }
            */

            var vehiclesList = vehiculos.Select(v => new VehicleListModel
            {
                Id = v.Id,
                Dominio = v.Dominio,
                AnioFabricacion = v.AnioFabricacion
            })
                .ToList();

            ViewData["MiTitulo"] = "My Vehicles";
            //ViewData["Vehicles"] = vehiclesList;

            ViewBag.Vehicles= vehiclesList;

            return View("List");
        }
    }
}
