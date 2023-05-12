using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void PlaceBuilding()
        {
            // Position einlesen

        }

        public void UpgradeBuilding()
        {

        }

        public int CalcTiberiumCount()
        {
            int test = 0;
            return test;
        }

        public int CalcPowerCount()
        {
            int test = 0;
            return test;
        }

        public int CalcBuildingCount()
        {
            int test = 0;
            return test;
        }

        public int CalcBuildingMax()
        {
            int test = 0;
            return test;
        }
    }
}
