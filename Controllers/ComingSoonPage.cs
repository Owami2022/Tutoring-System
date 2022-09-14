using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace TBHAcademy.Controllers
{
    public class ComingSoonPage : Controller
    {
        public IActionResult Index()
        {
            
            if (User.IsInRole("Administrator"))
			{
                ViewBag.Layout = "~/Views/Shared/_AdminLayout.cshtml";
            }
             else if(User.IsInRole("Tutor"))
			{
                ViewBag.Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";
			}
            else if( User.IsInRole("Head of Department"))

			{
                ViewBag.Layout = "~/Views/Shared/_HodLayout.cshtml";

            }
            else if (User.IsInRole("Student"))

            {
                ViewBag.Layout = "~/Views/Shared/_StudentLayout.cshtml";

            }
            else
			{
                return RedirectToAction();
			}
            return View();

          

        }
    }
}
