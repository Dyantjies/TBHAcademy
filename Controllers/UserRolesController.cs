using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
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
    public class UserRolesController : Controller
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly TBHAcademyContext _db;
        private readonly INotyfService _notyf;

        public UserRolesController(TBHAcademyContext db, INotyfService not,UserManager<TBHAcademyUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
            _notyf = not;
        }
        public async Task<IActionResult> UserRoleIndex()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (TBHAcademyUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Status = user.Status;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }
        private async Task<List<string>> GetUserRoles(TBHAcademyUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.userId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user.UserName;
            var model = new List<ManageUserRolesViewModel>();
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new ManageUserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Manage(List<ManageUserRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View();
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            return RedirectToAction("UserRoleIndex");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
                return NotFound();
            var user = await _db.Users.FirstOrDefaultAsync(s => s.Id == id);
            if (user.Status == (int)UserStatus.Inactive)
            {
                _notyf.Warning("This user is already Inactive");
            }
            else
            {
                user.Status = (int)UserStatus.Inactive;
                _notyf.Success("User Deactivated");
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(UserRoleIndex));
        }


        [HttpPost]
        public async Task<IActionResult> ActivateUser(string id)
        {
            if (id == null)
                return NotFound();


            var user = await _db.Users.FirstOrDefaultAsync(s => s.Id == id);
            if (user.Status == (int)UserStatus.Active)
            {
                _notyf.Warning("User already active");
            }
            else
            {
                user.Status = (int)UserStatus.Active;
                _notyf.Success("User Activated");
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(UserRoleIndex));
        }
    }
}
