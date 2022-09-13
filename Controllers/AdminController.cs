using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    // [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public AdminController(TBHAcademyContext db, INotyfService not, UserManager<TBHAcademyUser> userManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, SignInManager<TBHAcademyUser> signInManager)
        {
            _db = db;
            INotyfService not3;
            _userManager = userManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewBag.Courses = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            return View();
        }
        public IActionResult ListCourse()
        {
            //other person who will be using this view will exclude courses which are inactive  by saying ".where(x=>x.Status !=(int)CourseStatus.Inactive)"
            var course = _db.Course.Include(x => x.Faculty).OrderBy(x => x.CourseName).ToList();
            ViewBag.Message = "Manage Courses";
            return View(course);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null)
                return NotFound();
            var course = await _db.Course.FirstOrDefaultAsync(s => s.CourseId == id);
            if (course.Status == (int)CourseStatus.Inactive)
            {
                _notyf.Warning("This course is already Inactive");
            }
            else
            {
                course.Status = (int)CourseStatus.Inactive;
                _notyf.Success("Course Deactivated");
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ListCourse));
        }


        [HttpPost]
        public async Task<IActionResult> ActivateCourse(int? id)
        {
            if (id == null)
                return NotFound();


            var course = await _db.Course.FirstOrDefaultAsync(s => s.CourseId == id);
            if (course.Status == (int)CourseStatus.Active)
            {
                _notyf.Warning("Course already active");
            }
            else
            {
                course.Status = (int)CourseStatus.Active;
                _notyf.Success("Course Activated");
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ListCourse));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Faculty = _db.Faculty.OrderBy(x => x.FacultyName).ToList();

            ViewBag.Action = (id == 0) ? "Add" : "Update";
            var course = _db.Course.Find(id);
            if (id > 0)
            {
                return View(course);
            }
            else
            {
                return View(new Course());
            }
        }
        //got the views using id now editing begins.
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            return View();
        }
    }
}
           
           