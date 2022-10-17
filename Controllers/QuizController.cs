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
    public class QuizController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly IEmailSender _emailSender;

        public QuizController(TBHAcademyContext db, IEmailSender emailSender)
        {
            _db = db;
            _emailSender = emailSender;

        }
        public IActionResult Create_Quiz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create_Quiz(Quiz quiz, int ModuleID)
        {
            if(ModuleID > 0)
            {
                quiz.AssignedID = ModuleID;
                _db.Quiz.Add(quiz);
                _db.SaveChanges();
                return RedirectToAction("Content", "Module", new { id = ModuleID });
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Add_Quiz_Question()
        {
            ViewBag.Message = "Adding Questions";
            return View();
        }
        [HttpPost]
        public JsonResult Add_Quiz_Question(QuestionModel objquestionModel)
        {
            Questions questions = new Questions();
            questions.QNumber = objquestionModel.QuestionNum;
            questions.QuesDes = objquestionModel.QuestionDes;
            questions.IsMultiple =false;
            questions.QuizID = objquestionModel.QuizID;
            _db.Questions.Add(questions);
            _db.SaveChanges();

            int QuestionId = questions.QId;

            foreach (var item in objquestionModel.ListofOptions)
            {
                QuestionOptions options = new QuestionOptions();
                options.OpName = item;
                options.Qid = QuestionId;
                _db.QuestionOptions.Add(options);
                _db.SaveChanges();
            }

            QuestionAnswer Answer = new QuestionAnswer();
            Answer.AnsText = objquestionModel.QueAnswerTxt;
            Answer.Qid = QuestionId;
            _db.QuestionAnswers.Add(Answer);
            _db.SaveChanges();

            return Json(new { message = "Question Successfully Saved.", success = true}, objquestionModel);

        }
        public ActionResult Attempt()
        {
            //ViewBag.QuizInfor = from Q in _db.Quiz
            //                    where Q.QuizID == QuizId
            //                    select Q;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Attempt(Attempt attempt, int QuizID)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Attempt attempt = new Attempt();
            attempt.Date = DateTime.Now.ToString("dd/MMMM/yyyy");
            attempt.time = DateTime.Now.ToString("HH:mm:ss");
            attempt.QuizID = 1;
            attempt.StudentID = user;
            _db.Attempt.Add(attempt);
            _db.SaveChanges();
            return View();
        }
    }
}
