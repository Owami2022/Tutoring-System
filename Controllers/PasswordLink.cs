using Microsoft.AspNetCore.Mvc;

namespace TBHAcademy.Controllers
{
    public class PasswordLink : Controller
    {
        public IActionResult SendPasswordLink()
        {
            return View();
        }
    }
}
