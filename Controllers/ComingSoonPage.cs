using Microsoft.AspNetCore.Mvc;

namespace TBHAcademy.Controllers
{
    public class ComingSoonPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
