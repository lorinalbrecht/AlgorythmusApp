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
            Level lvl1 = new Level(1, 1);
            Level lvl2 = new Level(2, 2);
            Level lvl3 = new Level(3, 3);
            Level lvl4 = new Level(4, 4);
            Level lvl5 = new Level(5, 5);
            Level lvl6 = new Level(6, 6);
            Level lvl7 = new Level(7, 7);
            Level lvl8 = new Level(8, 8);
            Level lvl9 = new Level(9, 9);
            Level lvl10 = new Level(10, 10);
        }
    }
}
