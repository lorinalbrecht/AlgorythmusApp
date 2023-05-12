using AlgorythmusApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class LevelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // Seed for Standard Datas
        // Person person1 = new Person("Leopold", 6);
        public void Seed()
        {
            Level lvl1 = new(1, 1);
            Level lvl2 = new(2, 2);
            Level lvl3 = new(3, 3);
            Level lvl4 = new(4, 4);
            Level lvl5 = new(5, 5);
            Level lvl6 = new(6, 6);
            Level lvl7 = new(7, 7);
            Level lvl8 = new(8, 8);
            Level lvl9 = new(9, 9);
            Level lvl10 = new(10, 10);
        }
    }
}
