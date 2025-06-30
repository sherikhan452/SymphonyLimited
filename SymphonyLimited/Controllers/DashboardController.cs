using Microsoft.AspNetCore.Mvc;

namespace SymphonyLimited.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
