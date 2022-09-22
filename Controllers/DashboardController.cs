using Microsoft.AspNetCore.Mvc;

namespace TBHAcademy.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
