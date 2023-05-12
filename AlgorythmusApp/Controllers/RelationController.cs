using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class RelationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public decimal CalcReturnOfInvestment()
        {
            decimal test = 2.3m;
            return test;
        }
    }
}
