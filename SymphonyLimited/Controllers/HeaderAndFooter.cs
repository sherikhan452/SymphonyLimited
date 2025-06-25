using Microsoft.AspNetCore.Mvc;

namespace SymphonyLimited.Controllers
{
    public class HeaderAndFooter : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
