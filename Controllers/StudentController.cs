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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace TBHAcademy.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly IEmailSender _emailSender;

        public StudentController(TBHAcademyContext db, IEmailSender emailSender)
        {
            _db = db;
            _emailSender = emailSender;

        }
        //public IActionResult Index()
        //{
        //    IEnumerable<Enroll> List1 = _db.Enroll;
        //    return View(List1);
        //}
        //public async Task<IViewComponentResult> Invoke()
        //{
        //    //var user = _db.Users.Where(x => x.Id == user1).FirstOrDefault();
        //    var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var Modules =(from  m in _db.Modules
        //                  join A in _db.AssignModules on m.ModuleId equals A.ModuleID
        //                  from E in _db.Enroll
        //                  join U in _db.Users on E.StudentID equals U.Id
        //                  where A.AssignedID == E.ModuleID && E.StudentID == user
        //                  select new ModuleDisplay { AssignModulesVM = A, ModulesVM = m, EnrollVM = E, UserVM = U };
        //    return View(" ",Modules.ToList());

        //}

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Index()
        {
            //To get student Modules
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                           join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                           from E in _db.Enroll
                           join U in _db.Users on E.StudentID equals U.Id
                           where A.AssignedID == E.ModuleID && E.StudentID == user
                           select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E}).ToList();
       

            return View();
        }

        public IActionResult Enroll()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();
            //List<Modules> modules = new List<Modules>();
            //List<Course> courses = new List<Course>();
            ViewBag.Message = "Enroll a New Module";
            //IEnumerable<int> enumerable = Enumerable.Range(1, 300);
            //List<int> list = enumerable.ToList();
           ViewBag.modules = (from c in _db.Course
                                join m in _db.Modules on c.CourseId equals m.CourseId
                                from U in _db.Users
                                join AU in _db.AssignModules on U.Id equals AU.TutorID
                                
                                where AU.ModuleID == m.ModuleId                    
                                select new ModuleDisplay { ModulesVM = m, CourseVM = c, UserVM = U, AssignModulesVM = AU}).ToList();
            

            return View();
            
        }
        //[HttpPost]
        //public IActionResult Enroll(ModuleDisplay md,int? iD)
        //{
        //    Enroll enroll = new Enroll();
            
        //       var id = _userManager.GetUserId(User);
        //        enroll.DateErolled = DateTime.Today;
        //        enroll.ModuleID = Convert.ToInt32(iD);
         
                
        //        _db.Enroll.Add(enroll);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index1");
        //        //ViewBag.Massege = "You have Succesfullly Enrolled.";
       
            

        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enrolled(Enroll enroll,int iD)
        {

            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();
            ViewBag.test = (from m in _db.Modules
                            join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                            from E in _db.Enroll
                            join U in _db.Users on E.StudentID equals U.Id
                            where A.AssignedID == E.ModuleID && E.StudentID == user && E.ModuleID == iD
                            select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();
            enroll.DateErolled = DateTime.Today;
            enroll.ModuleID = iD;
            enroll.StudentID = user;
            if (ViewBag.test == null)
            {
                return RedirectToAction("Enroll");
                await _emailSender.SendEmailAsync("mosenakoketso2018@gmail.com", "Enrollement Notification",
                     $"PleaseNote you have alreaddy for the module");
                ViewBag.TestResult = " Already Enrolled Module";
            }
            else
            {

                _db.Enroll.Add(enroll);
                _db.SaveChanges();
                await _emailSender.SendEmailAsync("mosenakoketso2018@gmail.com", "Enrollement Notification",
                      $"Thank you for Enrolling with us");
                return RedirectToAction("Enroll");
            }



        }
        public IActionResult Enrolled()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Find_Mates()
        {
            ViewBag.Studets = from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where R.Name == "Student" && U.Id == UR.UserId
                              select U;
            return View();
        }

    }
}
