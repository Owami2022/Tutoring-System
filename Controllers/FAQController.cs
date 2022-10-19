using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    public class FAQController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public FAQController(TBHAcademyContext db, INotyfService not, UserManager<TBHAcademyUser> userManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, SignInManager<TBHAcademyUser> signInManager)
        {
            _db = db;
            _notyf = not;
            _userManager = userManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DiplayFAQs()
        {
            IEnumerable<FAQ> DiplayFAQs = _db.fAQs;
            return View(DiplayFAQs);

        }
    }
}
