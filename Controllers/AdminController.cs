using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public AdminController(TBHAcademyContext db, INotyfService not, UserManager<TBHAcademyUser> userManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, SignInManager<TBHAcademyUser> signInManager)
        {
            _db = db;
            _notyf = not;
            _userManager = userManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewBag.Courses = _db.Course.Count(x => x.CourseId > 0);
            ViewBag.Faculty = _db.Faculty.Count(x => x.FacultyId > 0);
            return View();
        }
        public IActionResult ListCourse()
        {
            //other person who will be using this view will exclude courses which are inactive  by saying ".where(x=>x.Status !=(int)CourseStatus.Inactive)"
            var course = _db.Course.Include(x => x.Faculty).OrderBy(x => x.CourseName).ToList();
            ViewBag.Message = "Manage Courses";
            return View(course);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null)
                return NotFound();
            var course = await _db.Course.FirstOrDefaultAsync(s => s.CourseId == id);
            if (course.Status == (int)CourseStatus.Inactive)
            {
                _notyf.Warning("This course is already Inactive");
            }
            else
            {
                course.Status = (int)CourseStatus.Inactive;
                _notyf.Success("Course Deactivated");
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ListCourse));
        }


        [HttpPost]
        public async Task<IActionResult> ActivateCourse(int? id)
        {
            if (id == null)
                return NotFound();


            var course = await _db.Course.FirstOrDefaultAsync(s => s.CourseId == id);
            if (course.Status == (int)CourseStatus.Active)
            {
                _notyf.Warning("Course already active");
            }
            else
            {
                course.Status = (int)CourseStatus.Active;
                _notyf.Success("Course Activated");
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ListCourse));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Faculty = _db.Faculty.OrderBy(x => x.FacultyName).ToList();

            ViewBag.Action = (id == 0) ? "Add" : "Update";
            var course = _db.Course.Find(id);
            if (id > 0)
            {
                return View(course);
            }
            else
            {
                return View(new Course());
            }
        }
        //got the views using id now editing begins.
        [HttpPost]
        public IActionResult Edit(Course course)
        {

            if (ModelState.IsValid)
            {
                if (course.CourseId == 0)
                {
                    ViewBag.Faculty = _db.Faculty.OrderBy(x => x.FacultyName).ToList();
                    _db.Course.Add(course);
                    _notyf.Success("Course Added");
                }
                else if (course.CourseId == course.CourseId && course.CourseId > 0)
                {
                    _db.Course.Update(course);
                    _notyf.Success("Course Updated");
                }
                _db.SaveChanges();
            }
            else
            {
                ViewBag.Action = (course.CourseId == 0) ? "Add" : "Update";
                ViewBag.Faculty = _db.Faculty.OrderBy(x => x.FacultyName).ToList();

                return View(course);
            }

            return RedirectToAction("ListCourse");
        }
        [HttpGet]
        public IActionResult EditUsers(string id)
        {
            //selecting the user that matches the id then gives me the first record
            var user = _db.Users.Where(x => x.Id == id).FirstOrDefault();

            if (!string.IsNullOrEmpty(id))
            {
                return View(user);
            }
            else
            {
                return View(new TBHAcademyUser());
            }
        }
        //public async Task<IActionResult> EditUsers(TBHAcademyUser model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var user = new TBHAcademyUser { UserName = Input.Email,
        //             Email = model.Email,
        //             FirstName = model.FirstName,
        //             LastName = model.LastName,
        //             DOB = model.DOB,
        //             Gender = model.Gender,
        //             Role = "Student",
        //             Status = "Active",
        //             date = DateTime.Today 
        //         };
        //         var result = await _userManager.CreateAsync(user, Input.Password);
        //         if (result.Succeeded)
        //         {
        //             var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //             code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        //             var callbackUrl = Url.Page(
        //                 "/Account/ConfirmEmail",
        //                 pageHandler: null,
        //                 values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
        //                 protocol: Request.Scheme);

        //             await IEmailSender.SendEmailAsync(model.Email, "Confirm your email",
        //                 $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

        //             if (_userManager.Options.SignIn.RequireConfirmedAccount)
        //             {
        //                 return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
        //             }
        //         }
        //         foreach (var error in result.Errors)
        //         {
        //             ModelState.AddModelError(string.Empty, error.Description);
        //         }
        //     }

        // }


        //Roles 
        [HttpGet]
        public IActionResult Roles()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Roles(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName

                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Role");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);

                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var Roles = _roleManager.Roles;
            return View(Roles);
        }
        //public async Task<IActionResult> EditRole(string id)
        //{
        //    var users = _db.Users.ToList();
        //    var role = await _roleManager.FindByIdAsync(id);
        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id={id} cannot be found";

        //        return View("NotFound");
        //    }
        //    var model = new EditRoleViewModel
        //    {
        //        Id = role.Id,
        //        RoleName = role.Name
        //    };
        //    foreach (var user in users)
        //    {
        //        if (await _userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            model.Users.Add(user.UserName);
        //        }
        //    }
        //    return View(model);
        //}
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return Redirect("/");
            }

        }

        public IActionResult FAQs()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FAQs(FAQ fAQ)
        {
            if (ModelState.IsValid)
            {
                _db.fAQs.Add(fAQ);
                _db.SaveChanges();
                return RedirectToAction("ListFAQs");
            }
            return View(fAQ);
        }

        public IActionResult ListFAQs()
        {
            {
                IEnumerable<FAQ> FAQsList = _db.fAQs;
                return View(FAQsList);
            }




        }
        [HttpGet]
        public IActionResult EditFAQs(int id)
        {


            ViewBag.Action = (id == 0) ? "Add" : "Update";
            var fAQ = _db.fAQs.Find(id);
            if (id > 0)
            {
                return View(fAQ);
            }
            else
            {
                return View(new FAQ());
            }
        }


        public IActionResult DiplayFAQs()
        {
            IEnumerable<FAQ> DiplayFAQs = _db.fAQs;
            return View(DiplayFAQs);

        }


        [HttpGet]
        public async Task<IActionResult> DeleteFAQ(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var schedule = await _db.fAQs.AsNoTracking().FirstOrDefaultAsync(s => s.FAQId == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        [HttpPost, ActionName("DeleteFAQ")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFAQConfirm(int? id)
        {
            var fAQ = await _db.fAQs.FindAsync(id);
            if (fAQ == null)
            {
                return RedirectToAction("ListFAQs", "Admin");
            }
            try
            {
                _db.fAQs.Remove(fAQ);
                await _db.SaveChangesAsync();
                return RedirectToAction("ListFAQs", "Admin");
            }
            catch (DbUpdateException)
            {
                return RedirectToAction(nameof(DeleteFAQ));
            }
        }

    }
}
           
           