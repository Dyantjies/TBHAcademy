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

namespace TBHAcademy.Controllers
{
    [Authorize(Roles = "Tutor")]
    public class TutorController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;

        public TutorController(TBHAcademyContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CapturetMarklist()
        {
            IEnumerable<TeamMark> teamMarks = _db.TeamMark;
            return View(teamMarks);
        }
        public IActionResult Calender()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult InsertMark(TeamMark teamMark)
        {
            if (ModelState.IsValid)
            {
                _db.TeamMark.Add(teamMark);
                _db.SaveChanges();
                return RedirectToAction("Index", "Tutor");
            }
            return View(teamMark);
        }

        public IActionResult TearmResultUpdate(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.TeamMark.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TearmResultUpdate(TeamMark teamMark)
        {
            _db.TeamMark.Update(teamMark);
            _db.SaveChanges();
            return RedirectToAction("Index", "Tutor");
        }

        public IActionResult DeleteTermMark(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.TeamMark.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTermMark(TeamMark teamMark)
        {
            ViewBag.Message = teamMark.StName + "Will be Deleted!";
            _db.TeamMark.Remove(teamMark);
            _db.SaveChanges();
            return RedirectToAction("CapturetMarklist", "Tutor");

        }
        public IActionResult CreateAnnouncement()
        {
            return View();
        }
        public IActionResult Announcements()
        {
            IEnumerable<Announcements> Announcements = _db.Announcements;
            return View(Announcements);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAnnouncement(Announcements announcements)
        {
            if (ModelState.IsValid)
            {
                _db.Announcements.Add(announcements);
                _db.SaveChanges();
                return RedirectToAction("Announcements");
            }
            return View(announcements);
        }

        public IActionResult DiplayFAQs()
        {
            IEnumerable<FAQ> DiplayFAQs = _db.fAQs;
            return View(DiplayFAQs);

        }

        //public IActionResult CreateMeeting()
        //{

        //}




    }
}
