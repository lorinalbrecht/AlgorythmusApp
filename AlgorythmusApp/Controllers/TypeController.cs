using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class TypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Seed for Standard Datas
        // Person person1 = new Person("Leopold", 6);
        public void Seed()
        {
            Type Silo = new Type(1, "Silo");
            // Type Harvester = new Type(2, "Harvester");
        }
    }
}
