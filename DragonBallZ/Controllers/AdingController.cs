using Microsoft.AspNetCore.Mvc;

namespace DragonBallZ.Controllers
{
    public class AdingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
    }
}
