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

            return Json(new {message = "Question Successfully Saved.",success = true}, objquestionModel);

        }

    }
}
