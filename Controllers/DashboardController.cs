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
    public class DashboardController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;

        public DashboardController(TBHAcademyContext db)
        {
            _db = db;

        }
        public IActionResult Student()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();


            return View();
        }
        public IActionResult Hod()
        {
            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            ViewBag.Course = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.Enroll = _db.Enroll.Count(x => x.EnrolledID > 0);
            IEnumerable<Faculty> FacultyList = _db.Faculty;
            return View(FacultyList);
        }

        public IActionResult Admin()
        {
            ViewBag.Course = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            //ViewBag.Users = _db.Users.Count(x => x.AccessFailedCount > 0);
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.Enroll = _db.Enroll.Count(x => x.EnrolledID >= 0);
            IEnumerable<Course> CourseList = _db.Course;
            return View(CourseList);

        }
    }
}
