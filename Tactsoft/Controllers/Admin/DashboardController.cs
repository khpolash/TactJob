using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Controllers.Admin
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
