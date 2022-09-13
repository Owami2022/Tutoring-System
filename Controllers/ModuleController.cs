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
            string TutorID = "fgsgsggg";
            int mOdule = 1;
            //getting the 

            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);


            if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "~/Views/Shared/_StudentLayout.cshtml";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";
            }
            else
            {
                return RedirectToAction();
            }
            var Module = _db.Modules.Where(x => x.ModuleId == mOdule).FirstOrDefault();
            ViewBag.Header = /*Module.ModuleCode + " " + Module.ModuleName;*/ "JHAA402 Commercial Law";
            //var content; = from am in _db.AssignModules
            //                    join t in _db.Topic on am.AssignedID equals t.AssignedModuleId
            //                    from c in _db.Content
            //                    join t2 in _db.Topic on c.TopicID equals t2.TopicId
            //                    from am2 in _db.AssignModules
            //                    join U in _db.Users on am2.TutorID equals U.Id
            //                    from m in _db.Modules 
            //                    join am3 in _db.AssignModules on m.ModuleId equals am3.ModuleID

            //                    where am.ModuleID == mOdule && U.Id == TutorID
            //                    select new ManageContent { assignModules = am, topic = t, UserVM = U, content = c };

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ManageContent manageContent)
        {
            Content content = new Content();
            Topic topic = new Topic();

            //Assigning to content
            //content.ContentId = manageContent.content.ContentId;
            content.Document1 = manageContent.content.Document1;
            content.Document2 = manageContent.content.Document2;
            content.Document3 = manageContent.content.Document3;
            content.Document4 = manageContent.content.Document4;
            content.Document5 = manageContent.content.Document5;
            content.DocumentDescription1 = manageContent.content.DocumentDescription1;
            content.DocumentDescription2 = manageContent.content.DocumentDescription2;
            content.DocumentDescription3 = manageContent.content.DocumentDescription3;
            content.DocumentDescription4 = manageContent.content.DocumentDescription4;
            content.DocumentDescription5 = manageContent.content.DocumentDescription5;
            content.Link1 = manageContent.content.Link1;
            content.Link2 = manageContent.content.Link2;
            content.Link3 = manageContent.content.Link3;
            content.Link4 = manageContent.content.Link4;
            content.Link5 = manageContent.content.Link5;
            //content.TopicID = manageContent.content.TopicID;

            //Assigning to Topic
            topic.TopicId = manageContent.topic.TopicId;
            topic.TopicName = manageContent.topic.TopicName;
            topic.TopicDescription = manageContent.topic.TopicDescription;
            topic.AssignedModuleId = 21;

            if (topic != null || content != null)
            {
                _db.Topic.Add(topic);
                _db.SaveChanges();


                _db.Content.Add(content);
                _db.SaveChanges();
                _notyf.Success("Success Full Added The Content");

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
        public IActionResult AddTopics(Topic topic)
        {
            if (ModelState.IsValid)
            {
                _db.Topic.Add(topic);
                _db.SaveChanges();
                //_notyf.Success("Successfully Added a Topic");
                return RedirectToAction("Content");
            }
            return View();
        }
    }
}
