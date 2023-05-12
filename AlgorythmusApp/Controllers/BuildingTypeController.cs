using AlgorythmusApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class BuildingTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Seed for Standard Datas
        // Person person1 = new Person("Leopold", 6);
        public void Seed()
        {
            BuildingType Silo = new(1, "Silo");
            BuildingType Harvester = new(2, "Harvester");
        }
    }
}
