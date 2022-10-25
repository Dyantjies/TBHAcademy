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
using System.Security.Claims;
using System.Threading.Tasks;

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
            if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "_TutorLayoutcshtml";
            }
            else if (User.IsInRole("Head of Department"))
            {
                ViewBag.Layout = "_HodLayout";
            }
            else if (User.IsInRole("Administrator"))
            {
                ViewBag.Layout = "_AdminLayout";
            }

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
             if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "_TutorLayoutcshtml";
            }
            else if (User.IsInRole("Head of Department"))
            {
                ViewBag.Layout = "_HodLayout";
            }
            else if (User.IsInRole("Administrator"))
            {
                ViewBag.Layout = "_AdminLayout";
            }
            //ViewBag.User = _db.Users.OrderBy(x=>x.UserName).ToList();
            ViewBag.Users = from u in _db.Users
                            select u;
            ViewBag.Modules = (from M in _db.Modules
                              join A in _db.AssignModules on M.ModuleId
                              equals A.ModuleID
                              select new ModuleDisplay { ModulesVM = M, AssignModulesVM = A}).ToList();
                              


            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ScheduleMeeting schedule)
        {
           
           schedule.CreatorID =  User.FindFirstValue(ClaimTypes.NameIdentifier);
            _db.ScheduleMeeting.Add(schedule);
                _db.SaveChanges();
            var user = _db.Users.FirstOrDefault(X => X.Id == schedule.CreatorID);
            var user2 = _db.Users.FirstOrDefault(X => X.Id == schedule.MemberId);
            if (schedule.ModuleID != 0)
            {
                List<TBHAcademyUser> User = new List<TBHAcademyUser>();
                User = (from AS in _db.AssignModules
                       join E in _db.Enroll on AS.ModuleID equals E.ModuleID
                       join U in _db.Users on E.StudentID equals U.Id
                       where AS.ModuleID == schedule.ModuleID
                       select U).ToList();
                
                //foreach (var obj in User)
                //{
                //    await _emailSender.SendEmailAsync(obj.Email, "Meeting Invitation",
                //    $"<h3>Hey"+user.FirstName+ user.LastName + "</h3> <br/><h5>You Have Been Inivited To A Meeting</h5><br/>Below is the Meeting Information <br/>Meeting Host: "+ user.FirstName + user.LastName + "<br/>" +
                //    "Meeting Title: "+schedule.Title+"<br/> Meeting Description: "+ schedule.Description+"<br/>Meeting Date: "+schedule.AppointmentDate+" <br/> Meeting Link: " + "<a href='schedule.Link'>join</a>.");
                //}

            }
            if(schedule.MemberId != "0")
            {
                
                //await _emailSender.SendEmailAsync(user2.Email,"Meeting Invitation",
                //    $"<h3>Hey" + user.FirstName + user.LastName + "</h3> <br/><h5>You Have Been Inivited To A Meeting</h5><br/>Below is the Meeting Information <br/>Meeting Host: " + user.FirstName + user.LastName + "<br/>" +
                //    "Meeting Title: " + schedule.Title + "<br/> Meeting Description: " + schedule.Description + "<br/>Meeting Date: " + schedule.AppointmentDate + " <br/> Meeting Link: " + "<a href='schedule.Link'>join</a>.");

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
