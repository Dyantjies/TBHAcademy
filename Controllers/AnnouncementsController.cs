using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    public class AnnouncementsController : Controller
    {


        private readonly TBHAcademyContext _db;
        //private readonly INotyfService _notyf;
        //private readonly IEmailSender _emailSender;
        //private readonly UserManager<TBHAcademyUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly SignInManager<TBHAcademyUser> _signInManager;
        public AnnouncementsController(TBHAcademyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            ViewBag.Announcements = _db.Announcements.Count(x => x.AnnouncementId > 0);
            IEnumerable<Announcements> Announcements = _db.Announcements;

            if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "_TutorLayoutcshtml";
            }
            else if (User.IsInRole("Administrator"))
            {
                ViewBag.Layout = "_AdminLayout";
            }
            else if (User.IsInRole("Head of Department"))
            {
                ViewBag.Layout = "_HodLayout";
            }
            return View(Announcements);
        }
    }
}
