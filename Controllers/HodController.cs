using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    [Authorize(Roles = "Head of Department")]
    public class HodController : Controller
    {
        private readonly TBHAcademyContext _db;
        //private readonly INotyfService _notyf;
        //private readonly IEmailSender _emailSender;
        //private readonly UserManager<TBHAcademyUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly SignInManager<TBHAcademyUser> _signInManager;
        public HodController(TBHAcademyContext db)
        {
            _db = db; 
        }
        public List<Faculty> Faculties()
        {
            List<Faculty> faculties = _db.Faculty.ToList();
            return faculties;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult InsertModule()
        {
            ViewBag.Course = _db.Course.OrderBy(x => x.CourseName).ToList();

            return View();
        }
        public IActionResult InsertFaculty()
        {

            return View();
        }
        public IActionResult CreateAnnouncement()
        {
            return View();
        }

        public IActionResult ListFaculty()
        {
            IEnumerable<Faculty> FacultyList = _db.Faculty;
            return View(FacultyList);
        }
        public IActionResult Announcements()
        {
            IEnumerable<Announcements> Announcements = _db.Announcements;
            return View(Announcements);
        }
        public IActionResult ListModules()
        {

            IEnumerable<Modules> ModulesList = _db.Modules;
            return View(ModulesList);
        }
        public IActionResult DeleteModule(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Modules.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _db.Faculty.Add(faculty);
                _db.SaveChanges();
                return RedirectToAction("ListFaculty");
            }
            return View(faculty);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAnnouncement(Announcements announcements)
        {
            if(ModelState.IsValid)
            {
                _db.Announcements.Add(announcements);
                _db.SaveChanges();
                return RedirectToAction("Announcements");
            }
            return View(announcements);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteModule(Modules modules)
        {
            ViewBag.Message = modules.ModuleName + "Will be Deleted!";
            _db.Modules.Remove(modules);
            _db.SaveChanges();
            return RedirectToAction("ListModules", "Hod");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertModule(Modules modules)
        {
            if (ModelState.IsValid)
            {
                _db.Modules.Add(modules);
                _db.SaveChanges();
                return RedirectToAction("ListModules");
            }
            return View(modules);

        }
        public IActionResult DeleteFaculty(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Faculty.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteFaculty(Faculty faculty)
        {
            ViewBag.Message = faculty.FacultyName + "Will be Deleted!";
            _db.Faculty.Remove(faculty);
            _db.SaveChanges();
            return RedirectToAction("ListFaculty", "Hod");
        }
        
        
        [HttpPost]
        public async Task<IActionResult> ActivateFaculty(int? id)
        {
            if (id == null)
                return NotFound();


            var faculty = await _db.Faculty.FirstOrDefaultAsync(s => s.FacultyId == id);
            if (faculty.Status == (int)CourseStatus.Active)
            {
                //_notyf.Warning("Faculty already active");
            }
            else
            {
                faculty.Status = (int)CourseStatus.Active;
                //_notyf.Success("Faculty Activated");
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ListFaculty));
        }
        //public IActionResult ListFaculty()
        //{
        //    IEnumerable<Faculty> FacultyList = _db.Faculty;
        //    return View(FacultyList);
        //}
        //[HttpPost]
        //public async Task<IActionResult> DeleteFaculty(int? id)
        //{
        //    if (id == null)
        //        return NotFound();
        //    var faculty = await _db.Faculty.FirstOrDefaultAsync(s => s.FacultyId == id);
        //    if (faculty.Status == (int)FacultyStatus.Inactive)
        //    {
        //        _notyf.Warning("This faculty is already Inactive");
        //    }
        //    else
        //    {
        //        faculty.Status = (int)FacultyStatus.Inactive;
        //        _notyf.Success("Faculty Deactivated");
        //        await _db.SaveChangesAsync();
        //    }
        //    return RedirectToAction(nameof(ListFaculty));
        //}
        public IActionResult UpdateFaculty(int? id)
        {
            if(id == null && id== 0)
            {
                return NotFound();
            }
            var faculty = _db.Faculty.Find(id);
            if(faculty == null)
            {
                return NotFound();
            }
            return View(faculty);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateFaculty(Faculty faculty)
        {
            _db.Faculty.Update(faculty);
            _db.SaveChanges();
            return RedirectToAction("ListFaculty");
        }
        public IActionResult UpdateModule(int? id)
        {
            ViewBag.Course = _db.Course.OrderBy(x => x.CourseName).ToList();
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var modules = _db.Modules.Find(id);
            if (modules == null)
            {
                return NotFound();
            }
            return View(modules);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateModule(Modules modules )
        {
            _db.Modules.Update(modules);
            _db.SaveChanges();
            return RedirectToAction("ListModules");
        }
        //****************************************TUTOR MODULE********************
        public IActionResult Assign()
        {
            ViewBag.Tutors =  from R in _db.Roles
                              join UR in _db.UserRoles on R.Id equals UR.RoleId
                              from U in _db.Users
                              join ur in _db.UserRoles on U.Id equals ur.UserId
                              where R.Name == "Tutor" && U.Id == UR.UserId
                              select U;
            ViewBag.Modules = _db.Modules.OrderBy(x => x.ModuleName).ToList();         


            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Assign(AssignModules assign)
        {
            if (ModelState.IsValid)
            {
                _db.AssignModules.Add(assign);
                _db.SaveChanges();
                return RedirectToAction("Assigned_Tutors");
            }
            return View();
        }
        public IActionResult Assigned_Tutors()
        {
            IEnumerable<AssignModules> AssignedList = _db.AssignModules;
            return View(AssignedList);
           
        }

        public IActionResult FAQ_Display()
        {
          IEnumerable<FAQ> FAQ_Display=_db.fAQs;
            return View();
        }
    }
}
