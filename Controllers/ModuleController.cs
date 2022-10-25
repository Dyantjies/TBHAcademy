
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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace TBHAcademy.Controllers
{
    [Authorize]
    public class ModuleController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        public const string SessionModule = "_Name";
        private readonly IEmailSender _emailSender;

        public ModuleController(TBHAcademyContext db, IEmailSender emailSender)
        {
            _db = db;
            _emailSender = emailSender;

        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Content(int ID)
        {
            HttpContext.Session.SetInt32(SessionModule, ID);
            ViewBag.Tittle = "Module Content";
            IEnumerable<Content> content = _db.Content;


            //int module = ID;


            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (User.IsInRole("Student"))
            {
                ViewBag.Content = from C in _db.Content
                                  where C.AssignId == ID
                                  select C;
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                
                ViewBag.Content = from C in _db.Content
                                  where C.AssignId == 1
                                  select C;
                ViewBag.Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";
            }
            else
            {
                return RedirectToAction();
            }
            //var Module = _db.Modules.Where(x => x.ModuleId == module).FirstOrDefault();
           
            //var content = from am in _db.AssignModules
            //              join m in _db.Modules on am.ModuleID equals m.ModuleId
            //              from U in _db.Users 
            //              join am2 in _db.AssignModules on U.Id equals am2.TutorID
            //              from c in _db.Content 
            //              join am3 in _db.AssignModules on c.AssignId equals am3.AssignedID
            //              where am.ModuleID == module 
            //              select new ManageContent { assignModules = am, UserVM = U, content = c };
            ViewBag.Bool = content;
             ViewBag.Header = /*Module.ModuleCode + " " + Module.ModuleName;*/ "JHAA402 Commercial Law";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Content content)
        {
            content.AssignId = 1;
            if (content.Title != null)
            {
                _db.Content.Add(content);
                _db.SaveChanges();
                //_notyf.Success("Successfully Added a Topic");
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
        public IActionResult AddTopics()
        {
            IEnumerable<Content> contList = _db.Content;
            return View(contList);
        }
        public IActionResult AddContent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContent(Content content)
        {
            content.AssignId = 1;
            if (content.Title != null)
            {
                _db.Content.Add(content);
                _db.SaveChanges();
                //_notyf.Success("Successfully Added a Topic");
                return RedirectToAction("Content");
            }
            else
            {
                _notyf.Error("Something went Wrong, Please try again");
                return View();
            }

        }
        public IActionResult Quiz()
        {
            return View();
        }

        // POST: Quizs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public ActionResult Attempt()
        {
            //ViewBag.QuizInfor = from Q in _db.Quiz
            //                    where Q.QuizID == QuizId
            //                    select Q;
            return View();
        }
        [HttpPost]
        public IActionResult Attempt(int QuizID)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Attempt attempt = new Attempt();
            attempt.Date = DateTime.Now.ToString("dd/MMMM/yyyy");
            attempt.time = DateTime.Now.ToString("HH:mm:ss");
            attempt.QuizID = 1;
            attempt.StudentID = user;
            _db.Attempt.Add(attempt);
            _db.SaveChanges();   
            return RedirectToAction("Quiz","Index");
        }
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new SubModel
                {
                    DateOfSub = DateTime.Now.ToString("dd/MMMM/yyyy/ HH:mm:ss"),
                    FileType = file.ContentType,
                    Extension = extension,
                    Description = fileName,
                    Name = description,
                    StudentID = user,
                    AssignmentID = Convert.ToInt32(HttpContext.Session.GetInt32(SessionModule)),
                    
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                _db.SubModel.Add(fileModel);
                _db.SaveChanges();
                var User = _db.Users.FirstOrDefault(X => X.Id == user);


                await _emailSender.SendEmailAsync(User.Email, "Assignment Submission",
                    $"<h3>Assignment Submitted</h3> <br/> File Name: "+description+" <br/> Date: "+fileModel.DateOfSub+".");
            }
           
            TempData["Message"] = "File successfully uploaded to Database";
            return  RedirectToAction("Content", new { id = 2 });

        }
        public ActionResult Submit()
        {

            return View();
        }
        public ActionResult Upload()
        {

            return View();
        }
        public async Task<IActionResult> DownloadFile(int id)
        {

            var file = await _db.Upload.Where(x => x.AssignmnetID == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.AssignmentDes + file.Extension);
        }
        public async Task<ActionResult> Upload1()
        {
            var SubViewModel = await LoadAllFiles1();
            ViewBag.Message = TempData["Message"];
            return View(SubViewModel);
            
        }
        private async Task<UploadVM> LoadAllFiles1()
        {
            var viewModel = new UploadVM();
            viewModel.File = await _db.Upload.ToListAsync();

            return viewModel;
        }
        public async Task<ActionResult> Submit1()
        {
             var SubViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(SubViewModel);
        }
        private async Task<SubViewModel> LoadAllFiles()
        {
            var viewModel = new SubViewModel();
            viewModel.File = await _db.SubModel.ToListAsync();
            
            return viewModel;
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.SubModel.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        public async Task<IActionResult> UploadAssignmnet(List<IFormFile> files, Upload upload)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new Upload
                {
                    CreatedDate = DateTime.Now.ToString("dd/MMMM/yyyy/ HH:mm:ss"),
                    FileType = file.ContentType,
                    Extension = extension,
                    FileName = fileName,
                    DueDate = upload.DueDate,
                    AssignmentDes = upload.AssignmentDes,
                    ModuleID = Convert.ToInt32(HttpContext.Session.GetInt32(SessionModule)),

                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                _db.Upload.Add(fileModel);
                _db.SaveChanges();
                var User = _db.Users.FirstOrDefault(X => X.Id == user);


                await _emailSender.SendEmailAsync(User.Email, "Assignment Uploaded",
                    $"<h3>Assignment Due Information</h3> <br/> File Name: " + fileModel.AssignmentDes + " <br/> Date: " + fileModel.DueDate + ".");
            }

            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("Content", new { id = 2 });

        }

    }
}
