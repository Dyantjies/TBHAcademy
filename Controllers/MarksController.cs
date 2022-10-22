using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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
using System.Collections.Generic;
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

namespace TBHAcademy.Controllers
{
    public class MarksController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public MarksController(TBHAcademyContext db, INotyfService not, UserManager<TBHAcademyUser> userManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, SignInManager<TBHAcademyUser> signInManager)
        {
            _db = db;
            _notyf = not;
            _userManager = userManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        // GET: MarksController
        public ActionResult Index()
        {
            return View();
        }

       

        //    <-------------------------Add/Capture Student Result------------------------->
        public IActionResult AddMark()
        {
            ViewBag.Student = from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where R.Name == "Student" && U.Id == UR.UserId
                              select U;

            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
 
            ViewBag.Modules = _db.Modules.OrderBy(x => x.ModuleName).ToList();

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMark(Mark_Capture mark)
        {
            if (ModelState.IsValid)
            {
                _db.Mark_Capture.Add(mark);
                _db.SaveChanges();
                return RedirectToAction("ListMarks");
            }
            return View(mark);

        }
        //    <-----------End of --------------Add/Capture Student Result------------------------->

        public IActionResult ListMarks()
        {
            ViewBag.Message = "Marks Display";

            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewBag.ProgressReport = (from AM in _db.AssignModules
                                      join M in _db.Modules on AM.ModuleID equals M.ModuleId
                                      from MC in _db.Mark_Capture
                                      join U in _db.Users on MC.StudentID equals U.Id
                                      where user == AM.TutorID && MC.ModuleID == M.ModuleId
                                      select  new  Capture_Mark_Display { AssignModules = AM, TBHAcademyUser = U, Mark_Capture = MC, Modules = M }).Distinct().ToList();
            return View();

        }
        
        public IActionResult UpdateMark(int? id)
        {
            ViewBag.Student = from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where R.Name == "Student" && U.Id == UR.UserId
                              select U;

            ViewBag.Action = (id == 0) ? "Add" : "Update";
            var obj = _db.Mark_Capture.Find(id);
            if (id > 0)
            {
                return View(obj);
            }
            else
            {
                return View(new Mark_Capture());
            }
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMark(Mark_Capture mark_Capture)
        {
            _db.Mark_Capture.Update(mark_Capture);
            _db.SaveChanges();
            return RedirectToAction("ListMarks", "Marks");
        }

        //----------------------------------------------------------
        public IActionResult ListMarks1()
        {
            ViewBag.Message = "Marks Display";

            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewBag.ProgressReport = (from AM in _db.AssignModules
                                      join M in _db.Modules on AM.ModuleID equals M.ModuleId
                                      from MC in _db.Mark_Capture
                                      join U in _db.Users on MC.StudentID equals U.Id
                                      where user == AM.TutorID && MC.ModuleID == M.ModuleId
                                      select new Capture_Mark_Display { AssignModules = AM, TBHAcademyUser = U, Mark_Capture = MC, Modules = M }).Distinct().ToList();
            return View();

        }


























































        // GET: MarksController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //public IActionResult Create()
        //{
        //    ViewBag.Student = from R in _db.Roles
        //                      join UR in _db.UserRoles on R.Id equals UR.RoleId
        //                      from U in _db.Users
        //                      join ur in _db.UserRoles on U.Id equals ur.UserId
        //                      where R.Name == "Student" && U.Id == UR.UserId
        //                      select U;

        //    ViewBag.Modules = _db.Modules.OrderBy(x => x.ModuleName).ToList();

        //    ViewBag.Comment = _db.Comment.OrderBy(x => x.CommentText).ToList();

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Marks marks)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Marks.Add(marks);
        //        _db.SaveChanges();
        //        return RedirectToAction("ListMarks");
        //    }
        //    return View(marks);

        //}
        //public IActionResult ListMarks()
        //{
        //    IEnumerable<Marks> Marks = _db.Marks;

        //    return View(Marks);
        //}


        // GET: MarksController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: MarksController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: MarksController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: MarksController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
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


    }
}
