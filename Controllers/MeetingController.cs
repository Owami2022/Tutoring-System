using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;
using System.Linq;
using TBHAcademy.Models;
using System.Collections.Generic;

namespace TBHAcademy.Controllers
{
    public class MeetingController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public MeetingController(TBHAcademyContext db)
        {
            _db = db;
        }

        // List meetings
        public ActionResult Index()
        {
            return View();
        }

        //public IActionResult ListFaculty()
        //{
        //    IEnumerable<Faculty> FacultyList = _db.Faculty;
        //    return View(FacultyList);
        //}
        public IActionResult ListMeetings()
        {
            IEnumerable<ScheduleMeeting> meetings = _db.ScheduleMeeting;
            return View(meetings);
        }
        // GET: MeetingController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: MeetingController/Create

        //[HttpPost]
        public IActionResult Create()
        {
            //ViewBag.User = _db.Users.OrderBy(x=>x.UserName).ToList();
            ViewBag.Student = from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where R.Name == "Student" && U.Id == UR.UserId
                              select U;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ScheduleMeeting schedule)
        {

            if (ModelState.IsValid)
            {
                _db.ScheduleMeeting.Add(schedule);
                _db.SaveChanges();
                return RedirectToAction("");
            }
            return View(schedule);
        }

        //public IActionResult AddMeeting()
        //{
        //    ViewBag.Student = from R in _db.Roles
        //                      join UR in _db.UserRoles on R.Id equals UR.RoleId
        //                      from U in _db.Users
        //                      join ur in _db.UserRoles on U.Id equals ur.UserId
        //                      where R.Name == "Student" && U.Id == UR.UserId
        //                      select U;

        //    return View();
        //}



        //public ActionResult try(){

        // POST: MeetingController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: MeetingController/Edit/5


        //public IActionResult UpdateMeeting(int id)
        //{
            
        //}



        //public IActionResult UpdateFaculty(int? id)
        //{
        //    if (id == null && id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var faculty = _db.Faculty.Find(id);
        //    if (faculty == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(faculty);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateFaculty(Faculty faculty)
        //{
        //    _db.Faculty.Update(faculty);
        //    _db.SaveChanges();
        //    return RedirectToAction("ListFaculty");
        //}

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MeetingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MeetingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MeetingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
