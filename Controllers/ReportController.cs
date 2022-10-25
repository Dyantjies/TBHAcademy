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
using Microsoft.EntityFrameworkCore;

namespace TBHAcademy.Controllers
{
    [Authorize]
    public class ReportsController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;

        public ReportsController(TBHAcademyContext db)
        {
            _db = db;

        }
        public IActionResult Progress_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();
            ViewBag.Message = "Progress Report";
            ViewBag.ProgressReport = (from AM in _db.AssignModules
                                      join M in _db.Modules on AM.ModuleID equals M.ModuleId
                                      from MC in _db.Mark_Capture
                                      join U in _db.Users on MC.StudentID equals U.Id
                                      where MC.StudentID == user && MC.ModuleID == AM.AssignedID 
                                      select new Capture_Mark_Display {AssignModules = AM, TBHAcademyUser = U, Mark_Capture = MC, Modules = M }).ToList();

                                     


            return View();
        }
        public IActionResult Enrolled_Modules_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();

             ViewBag.Message = "Enrolled Modules Report";
            
            ViewBag.date = DateTime.Now.ToString("dd-MMMM-yyyy");
            ViewBag.Enrolled = (from c in _db.Course
                                join C in _db.Modules on c.CourseId equals C.CourseId
                                from U in _db.Users
                                join AM in _db.AssignModules on U.Id equals AM.TutorID
                                from E in _db.Enroll
                                join std in _db.Users on E.StudentID equals std.Id
                                where E.StudentID == user && AM.ModuleID == C.ModuleId && E.ModuleID == AM.AssignedID
                                select new Enrolled_Module_Display { AssignModules = AM, Course = c, Enroll = E, Modules = C, TBHAcademyUser = U }).ToList();

            return View();
        }

        //public IActionResult MeetingHistory()
        //{
        //    ViewBag.Message = "Meeting History";
        //    ViewBag.DisplayMeeting = (from m in _db.ScheduleMeeting
        //                       join U in _db.Users on m.StudentId equals U.Id
        //                       where m.StudentId == U.Id
        //                       select new MyMeeting { ScheduleMeetingVM = m, UserVM = U }
        //           ).ToList();

        //    return View();

        //}
        public IActionResult Faculty_Report()
        {
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.date = DateTime.Now.ToString("dd-MMM-yyyy");
            ViewBag.Faculties = _db.Faculty.OrderBy(x => x.FacultyName).ToList();
            ViewBag.Faculty_Display = (from C in _db.Course
                                       join f in _db.Faculty on C.FacultyId equals f.FacultyId
                                       select new Faculties_Display { Faculty = f, Course = C }).ToList();
            ViewBag.Courses = _db.Course.OrderBy(x => x.CourseName).ToList();
            
            return View();
        }
        public IActionResult Faculty_Update_Report()
        {
            ViewBag.date = DateTime.Now.ToString("dd-MMM-yyyy");

            ViewBag.FacultyOverview = (from E in _db.Modules
                                       join M in _db.Enroll on E.ModuleId equals M.ModuleID
                                       from C in _db.Course
                                       join f in _db.Faculty on C.FacultyId equals f.FacultyId
                                       select new Faculties_Display { Faculty = f, Course = C, Modules = E }).ToList();
            return View();
        }
        public IActionResult Modules_Report()
        {

            IEnumerable<Modules> ModulesList = _db.Modules;
            ViewBag.date = DateTime.Now.ToString("dd-MMM-yyyy");
            return View(ModulesList);
        }

        public IActionResult Course_Info_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.date = DateTime.Now.ToString("dd-MMMM-yyyy");
            ViewBag.Course = (from c in _db.Course
                              join F in _db.Faculty on c.CourseId equals F.FacultyId
                              select new Course_Info_Display { Course = c, Faculty = F }).ToList();


            return View();
        }

        public IActionResult Academic_Info_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Modules = (from m in _db.Modules
                               join A in _db.AssignModules on m.ModuleId equals A.ModuleID
                               from E in _db.Enroll
                               join U in _db.Users on E.StudentID equals U.Id
                               where A.AssignedID == E.ModuleID && E.StudentID == user
                               select new MyModules { AssignModulesVM = A, ModulesVM = m, EnrollVM = E }).ToList();
            ViewBag.Message = "TBH Academy Info";

            ViewBag.date = DateTime.Now.ToString("dd-MMMM-yyyy");
            ViewBag.Enrolled = (from c in _db.Course
                                join C in _db.Modules on c.CourseId equals C.CourseId
                                from U in _db.Users
                                join AM in _db.AssignModules on U.Id equals AM.TutorID
                                from E in _db.Enroll
                                join std in _db.Users on E.StudentID equals std.Id
                                where E.StudentID == user && AM.ModuleID == C.ModuleId && E.ModuleID == AM.AssignedID
                                select new Academic_Info_Display { AssignModules = AM, Course = c, Enroll = E, Modules = C, TBHAcademyUser = U }).ToList();


            return View();
        }

        //public async Task<IActionResult> Users_Info_Report()
        //{
        //    //var users = await _userManager.Users.ToListAsync();
        //    //var userRolesViewModel = new List<UserRolesViewModel>();
        //    //foreach (TBHAcademyUser user in users)
        //    //{
        //    //    var thisViewModel = new UserRolesViewModel();
        //    //    thisViewModel.UserId = user.Id;
        //    //    thisViewModel.Email = user.Email;
        //    //    thisViewModel.FirstName = user.FirstName;
        //    //    thisViewModel.LastName = user.LastName;
        //    //    thisViewModel.Roles = await GetUserRoles(user);
        //    //    userRolesViewModel.Add(thisViewModel);
        //    //}
        //    //return View(userRolesViewModel);




        //}

        public IActionResult Users_Info_Report()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.date = DateTime.Now.ToString("dd-MMMM-yyyy");
            ViewBag.Users = from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where U.Id == UR.UserId
                              select U;
            return View();
        }

    }
}
