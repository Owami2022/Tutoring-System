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
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;

namespace TBHAcademy.Controllers
{
    [Authorize]
    public class ModuleController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;

        public ModuleController(TBHAcademyContext db, INotyfService not)
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
            IEnumerable<Content> content = _db.Content;
            //int module = ID;
            

            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";
            }
            else
            {
                return RedirectToAction();
            }
            //var Module = _db.Modules.Where(x => x.ModuleId == module).FirstOrDefault();
           
            //var content = from am in _db.AssignModules
            //              join m in _db.Modules on am.ModuleID equals m.ModuleId
            //              from U in _db.Users 
            //              join am2 in _db.AssignModules on U.Id equals am2.TutorID
            //              from c in _db.Content 
            //              join am3 in _db.AssignModules on c.AssignId equals am3.AssignedID
            //              where am.ModuleID == module 
            //              select new ManageContent { assignModules = am, UserVM = U, content = c };
            ViewBag.Bool = content;
             ViewBag.Header = /*Module.ModuleCode + " " + Module.ModuleName;*/ "JHAA402 Commercial Law";
            return View(content);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Content content)
        {
            content.AssignId = 1;
            if (content.Title != null)
            {
                _db.Content.Add(content);
                _db.SaveChanges();
                //_notyf.Success("Successfully Added a Topic");
                return RedirectToAction("Content");
            }
            else
            {
                _notyf.Error("Something went Wrong, Please try again");
                return View();
            }



        }

        public IActionResult Add()
        {

            return View();
        }
        public IActionResult AddTopics()
        {
            IEnumerable<Content> contList = _db.Content;
            return View(contList);
        }
        public IActionResult AddContent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContent(Content content)
        {
            content.AssignId = 1;
            if (content.Title != null)
            {
                _db.Content.Add(content);
                _db.SaveChanges();
                //_notyf.Success("Successfully Added a Topic");
                return RedirectToAction("Content");
            }
            else
            {
                _notyf.Error("Something went Wrong, Please try again");
                return View();
            }

        }

    }
}
