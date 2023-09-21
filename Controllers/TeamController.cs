using Microsoft.AspNetCore.Mvc;

namespace MatchdayAnalyzer.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Players()
        {
            return View();
        }
    }
}
