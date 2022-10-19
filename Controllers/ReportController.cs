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
using System.Runtime.CompilerServices;
namespace TBHAcademy.Controllers
{
    public class ReportsController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;

        public ReportsController(TBHAcademyContext db)
        {
            _db = db;

        }
        public IActionResult Progress_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.ProgressReport = (from AM in _db.AssignModules
                                      join M in _db.Modules on AM.ModuleID equals M.ModuleId
                                      from MC in _db.Mark_Capture
                                      join U in _db.Users on MC.StudentID equals U.Id
                                      where MC.StudentID == user && MC.ModuleID == AM.AssignedID 
                                      select new Capture_Mark_Display {AssignModules = AM, TBHAcademyUser = U, Mark_Capture = MC, Modules = M }).ToList();

                                     


            return View();
        }
        public IActionResult Enrolled_Modules_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.date = DateTime.Now.ToString("dd-MMMM-yyyy");
            ViewBag.Enrolled = (from c in _db.Course
                                join C in _db.Modules on c.CourseId equals C.CourseId
                                from U in _db.Users
                                join AM in _db.AssignModules on U.Id equals AM.TutorID
                                from E in _db.Enroll
                                join std in _db.Users on E.StudentID equals std.Id
                                where E.StudentID == user && AM.ModuleID == C.ModuleId && E.ModuleID == AM.AssignedID
                                select new Enrolled_Module_Display { AssignModules = AM, Course = c, Enroll = E, Modules = C, TBHAcademyUser = U }).ToList();


            return View();
        }
        public IActionResult Faculty_Report()
        {
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.date = DateTime.Now.ToString("dd-MMM-yyyy");
            ViewBag.Faculties = _db.Faculty.OrderBy(x => x.FacultyName).ToList();
            ViewBag.Courses = _db.Course.OrderBy(x => x.CourseName).ToList();

            ViewBag.Faculties = (from f in _db.Faculty
                                 join C in _db.Course on f.FacultyId equals C.CourseId
                                 where C.FacultyId == f.FacultyId
                                 select new Faculties_Display { Faculty = f, Course = C }).ToList();
            return View();
        }
        public IActionResult Modules_Report()
        {
            IEnumerable<Modules> ModulesList = _db.Modules;
            ViewBag.date = DateTime.Now.ToString("dd-MMM-yyyy");
            return View(ModulesList);
        }


    }
}
