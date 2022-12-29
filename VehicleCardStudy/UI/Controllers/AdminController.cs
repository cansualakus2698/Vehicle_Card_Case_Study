using Microsoft.AspNetCore.Mvc;
using VhCardBusiness.Abstract;
using VhCardDataAccess.Abstract;
using VhCardEntity.Concrete;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly IVehiclesTypeService vehiclesTypeService;

        public AdminController(IVehicleService vehicleService, IVehiclesTypeService vehiclesTypeService)
        {
            this.vehicleService = vehicleService;
            this.vehiclesTypeService = vehiclesTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vehicles()
        {
            var list = vehicleService.GetAll();
            return View(list);
        }

        public IActionResult VehicleAddOrUpdate(int? id)
        {
            if (id is not null)
            {
                var user = vehicleService.Get(k => k.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult VehicleAddOrUpdate(int? id, Vehicle vehicle)
        {
            if (id == null)
            {
                vehicleService.Add(vehicle);

            }
            else
            {
                vehicleService.Update(vehicle);
            }
            return RedirectToAction("Vehicles");
        }

        public IActionResult VehicleDelete(int id)
        {
            Vehicle vehicle = vehicleService.Get(u => u.Id == id);
            vehicleService.Delete(vehicle);
            return RedirectToAction("Vehicles");
        }
    }
}
