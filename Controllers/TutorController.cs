using Microsoft.AspNetCore.Mvc;
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

namespace TBHAcademy.Controllers
{
    public class TutorController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;

        public TutorController(TBHAcademyContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CaptureMark()
        {
            return View();
        }

        public IActionResult CapturetMarklist()
        {
            IEnumerable<TeamMark> teamMarks = _db.TeamMark;
            return View(teamMarks);
        }
        public IActionResult ListCapture()
        {
            return View();
        }
        public IActionResult Calender()
        {
            return View();
        }
        //[HttpPost]

        //public IActionResult Calendar()
        //{
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    IEnumerable<Item> objList = _db.Items;//Coming from our database
        //    return View(objList);
        //}




    }
}
