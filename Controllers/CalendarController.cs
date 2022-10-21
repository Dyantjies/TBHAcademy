﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;

namespace TBHAcademy.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        public IActionResult Index()
        {
            

            if (User.IsInRole("Student"))
            {
                ViewBag.Layout = "_StudentLayout - Copy";
            }
            else if (User.IsInRole("Tutor"))
            {
                ViewBag.Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";
            }
            else if (User.IsInRole("Administrator"))
            {
                ViewBag.Layout = "~/Views/Shared/_AdminLayoutcshtml.cshtml";
            }
            else if (User.IsInRole("Head of Department"))
            {
                ViewBag.Layout = "_HodLayout";
            }

            return View();
        }

    }
}
