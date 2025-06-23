using Microsoft.AspNetCore.Mvc;

namespace SymphonyLimited.Controllers
{
    public class FrontEnd : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
