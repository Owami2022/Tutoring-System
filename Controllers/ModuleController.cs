using Microsoft.AspNetCore.Mvc;
using TBHAcademy.Areas.Identity;
using TBHAcademy.Data;
using TBHAcademy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using TBHAcademy.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace TBHAcademy.Controllers
{
    public class ModuleController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;

        public ModuleController(TBHAcademyContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Content()
        {
            ViewBag.Tittle = "Module Content";
            string TutorID = "fgsgsggg";
            int mOdule = 1;
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(Id);
            var Role = await _userManager.GetRolesAsync(user);
            if (Role.Contains("Student"))
            {
                ViewBag.Layout = "~/Views/Shared/_StudentLayout.cshtml";
            }
            else if (Role.Contains("Tutor"))
            {
                ViewBag.Layout = "~/Views/Shared/_TutorLayout.cshtml";
            }
            else
            {
                return RedirectToAction();
            }
            var Module = _db.Modules.Where(x => x.ModuleId == mOdule).FirstOrDefault();
            ViewBag.Header = Module.ModuleCode + " " + Module.ModuleName;
           
            var content = from am in _db.AssignModules
                                join t in _db.Topic on am.AssignedID equals t.AssignedModuleId
                                from c in _db.Content
                                join t2 in _db.Topic on c.TopicID equals t2.TopicId
                                from am2 in _db.AssignModules
                                join U in _db.Users on am2.TutorID equals U.Id
                                from m in _db.Modules 
                                join am3 in _db.AssignModules on m.ModuleId equals am3.ModuleID

                                where am.ModuleID == mOdule && U.Id == TutorID
                                select new ManageContent { assignModules = am, topic = t, UserVM = U, content = c };

            return View(content);
        }
    }
}
