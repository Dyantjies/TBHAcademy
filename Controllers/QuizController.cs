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
using Microsoft.AspNetCore.Http;

namespace TBHAcademy.Controllers
{
    public class QuizController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly IEmailSender _emailSender;
        public const string SessionAswer = "_Name";
        public const string SessionQuiz = "_Name2";

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
        public IActionResult Attempt(int QuizID)
        {
            Attempt attempt = new Attempt();
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Attempt attempt = new Attempt();
            attempt.Date = DateTime.Now.ToString("dd/MMMM/yyyy");
            attempt.time = DateTime.Now.ToString("HH:mm:ss");
            attempt.QuizID = QuizID;
            attempt.StudentID = user;
            _db.Attempt.Add(attempt);
            _db.SaveChanges();
           
            HttpContext.Session.SetInt32(SessionQuiz, QuizID);
            return View("Question");
        }
        public async Task<IActionResult> Quiz([Bind("QuizID,QDescription,DActive,Attempts,Time,IsActive,AssignedID")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                _db.Add(quiz);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quiz);
        }
        public ActionResult Question()
        {
            //ViewBag.QuizInfor = from Q in _db.Quiz
            //                    where Q.QuizID == QuizId
            //                    select Q;
            return View();
        }
        public PartialViewResult UserQuestionAnswer()
        {
            int pageSize = 1;
            int pageNumber = 0;
            int Quiz = Convert.ToInt32(HttpContext.Session.GetInt32(SessionQuiz));
            if (HttpContext.Session.GetString(SessionAswer).ToString() == null)
            {
                pageNumber = pageNumber + 1;
            }
            //else
            //    //{
            //    //    List<StudentAnswer> StuAnswer = HttpContext.Session.GetString(SessionAswer) as List<StudentAnswer>;
            //    //}
                List<Questions> listofQuestiom = new List<Questions>();
             listofQuestiom = _db.Questions.Where(model => model.QuizID == 1).ToList();

            QuizQuestionAnswerViewModel objAnswerViewModel = new QuizQuestionAnswerViewModel();
            Questions objQuestion = new Questions();
            objQuestion = listofQuestiom.Skip((pageNumber - 1) * pageSize).Take(pageSize).FirstOrDefault();

            objAnswerViewModel.QuestionID = objQuestion.QId;
            objAnswerViewModel.QuestionDes = objQuestion.QuesDes;
            objAnswerViewModel.QuestionNumber = objQuestion.QNumber;
            objAnswerViewModel.ListOfQuizOptions = (from obj in _db.QuestionOptions
                                                    where obj.Qid == objQuestion.QId
                                                    select new QuizOptions()
                                                    {
                                                        optionName = obj.OpName,
                                                        OptionID = obj.OpID

                                                    }).ToList();

            return PartialView("QuizQuestionOption",objAnswerViewModel);
        }
    }
}

