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
    [Authorize]
    public class DashboardController : Controller
    {

        private readonly TBHAcademyContext _db;

        public DashboardController(TBHAcademyContext db)
        {
            _db = db;

        }
        public IActionResult Student()
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
                                      select new Capture_Mark_Display { AssignModules = AM, TBHAcademyUser = U, Mark_Capture = MC, Modules = M }).ToList();



            return View();
        }
        public IActionResult Hod()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Tutors = from R in _db.Roles
                             join UR in _db.UserRoles on R.Id equals UR.RoleId
                             from U in _db.Users
                             join ur in _db.UserRoles on U.Id equals ur.UserId
                             where R.Name == "Tutor" && U.Id == UR.UserId
                             select U;

            ViewBag.Students = from R in _db.Roles
                             join UR in _db.UserRoles on R.Id equals UR.RoleId
                             from U in _db.Users
                             join ur in _db.UserRoles on U.Id equals ur.UserId
                             where R.Name == "Student" && U.Id == UR.UserId
                             select U;

            ViewBag.OverseeLearning = (from C in _db.Course
                                       join F in _db.Faculty on C.FacultyId equals F.FacultyId
                                       from MC in _db.Mark_Capture
                                       join U in _db.Users on MC.StudentID equals U.Id
                                       from M in _db.Modules
                                       join E in _db.Enroll on M.ModuleId equals E.ModuleID
                                       where MC.ModuleID == M.ModuleId && MC.StudentID == E.StudentID
                                       select new Learning_Update {TBHAcademyUser = U, Modules = M, Mark_Capture = MC }).ToList();

            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            ViewBag.Course = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.Enroll = _db.Enroll.Count(x => x.EnrolledID > 0);
            IEnumerable<Faculty> FacultyList = _db.Faculty;
            return View(FacultyList);
        }

        public IActionResult Admin()
        {
            ViewBag.Course = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            //ViewBag.Users = _db.Users.Count(x => x.AccessFailedCount > 0);
            ViewBag.Modules = _db.Modules.Count(x => x.ModuleId > 0);
            ViewBag.Enroll = _db.Enroll.Count(x => x.EnrolledID >= 0);
          
            ViewBag.Users=_db.Users;
            IEnumerable<Course> CourseList = _db.Course;
            return View(CourseList);

        }
    }
}
