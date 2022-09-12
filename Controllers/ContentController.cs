using Microsoft.AspNetCore.Mvc;

namespace TBHAcademy.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
