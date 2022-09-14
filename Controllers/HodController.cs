﻿using AspNetCoreHero.ToastNotification.Abstractions;
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
    public class HodController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        public HodController(TBHAcademyContext db)
        {
            _db = db;
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

        public IActionResult ListFaculty()
        {
            IEnumerable<Faculty> FacultyList = _db.Faculty;
            return View(FacultyList);
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
        [HttpPost]
        public async Task<IActionResult> DeleteFaculty(int? id)
        {
            if (id == null)
                return NotFound();
            var faculty = await _db.Faculty.FirstOrDefaultAsync(s => s.FacultyId == id);
            if (faculty.Status == (int)CourseStatus.Inactive)
            {
                _notyf.Warning("This course is already Inactive");
            }
            else
            {
                faculty.Status = (int)CourseStatus.Inactive;
                _notyf.Success("Course Deactivated");
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ListFaculty));
        }
        
        
        [HttpPost]
        public async Task<IActionResult> ActivateFaculty(int? id)
        {
            if (id == null)
                return NotFound();


            var faculty = await _db.Faculty.FirstOrDefaultAsync(s => s.FacultyId == id);
            if (faculty.Status == (int)CourseStatus.Active)
            {
                _notyf.Warning("Faculty already active");
            }
            else
            {
                faculty.Status = (int)CourseStatus.Active;
                _notyf.Success("Faculty Activated");
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
            var assignedtutor = (from m in _db.AssignModules
                                 join u in _db.Users on m.TutorID equals u.Id
                                 from c in _db.Course
                                 join o in _db.Modules on c.CourseId equals o.CourseId
                                 where m.ModuleID == o.ModuleId
                                 select new TutorModule { CourseTM = c, ModulesTM = o, AssignTM = m, UserTM = u });
            return View(assignedtutor);
        }
        public IActionResult Calendar()
        {
            return View();
        }
    }
}
