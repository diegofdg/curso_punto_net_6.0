using _36_IntroduccionMVC.Data;
using _36_IntroduccionMVC.Data.Entities;
using _36_IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _36_IntroduccionMVC.Controllers
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

        [HttpPost]
        public async Task<IActionResult> Create(Vehiculo vehiculo)
        {
            try
            {
                _dbContext.Add(vehiculo);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction(nameof(Index));
                //throw;
            }
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
