﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly SignInManager<TBHAcademyUser> _signInManager;

        public IndexModel(
            UserManager<TBHAcademyUser> userManager,
            SignInManager<TBHAcademyUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "First Name")]
            public string FirstName { get; set; }
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Profile Picture")]
            public byte[] ProfilePicture { get; set; }

            [Display(Name = "Address Line 1")]
            public string AddressLine1 { get; set; }

            [Display(Name = "Address Line 2")]
            public string AddressLine2 { get; set; }


            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(TBHAcademyUser user)
        {
            

            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var firstName = user.FirstName;
            var lastName = user.LastName;
            var profilePicture = user.MyPicture;
            var addressline1 = user.AddressLine1;
            var addressline2 = user.AddressLine2;
            Username = userName;
            

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                 FirstName = firstName,
                LastName = lastName,
                AddressLine1 = addressline1,
                AddressLine2 = addressline2,
                ProfilePicture = profilePicture,

            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);


            var firstName = user.FirstName;
            var lastName = user.LastName;
            var addressline1 = user.AddressLine1;
            var addressline2 = user.AddressLine2;
            if (Input.FirstName != firstName)
            {
                user.FirstName = Input.FirstName;
                await _userManager.UpdateAsync(user);
            }
            if (Input.LastName != lastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }
            if (Input.AddressLine1 != addressline1)
            {
                user.AddressLine1 = Input.AddressLine1;
                await _userManager.UpdateAsync(user);
            }
            if (Input.AddressLine2 != addressline2)
            {
                user.AddressLine2 = Input.AddressLine2;
                await _userManager.UpdateAsync(user);
            }
            if (user == null)
            {

                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    user.MyPicture = dataStream.ToArray();
                }
                await _userManager.UpdateAsync(user);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
