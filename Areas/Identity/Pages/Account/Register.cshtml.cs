using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<TBHAcademyUser> _signInManager;
        private readonly UserManager<TBHAcademyUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;


        public RegisterModel(
            UserManager<TBHAcademyUser> userManager,
            SignInManager<TBHAcademyUser> signInManager,
            ILogger<RegisterModel> logger,

            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
           
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
            [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
            [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Date of birth is required")]
            [DataType(DataType.Date)]
            public DateTime DOB { get; set; }
            [Required]
            [Display(Name = "Gender")]
            public string Gender { get; set; }

            [Required]
            [Display(Name = "Status")]
            public string Status { get; set; }

            [Required]
            [Display(Name = "Role")]
            public string Role { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Eamil")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public DateTime date { get; set; }
            public InputModel()
            {
                Status = "Active";
                Role = "Student";
            }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new TBHAcademyUser { UserName = Input.Email, Email = Input.Email, FirstName = Input.FirstName, LastName = Input.LastName, DOB = Input.DOB, Gender = Input.Gender, Role = "Student", Status = 0, date = DateTime.Today };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                       
                        return RedirectToPage("Login");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            return Page();
        }
        public async Task<IActionResult> VerifyEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null) return BadRequest();

            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (result.Succeeded)
            {
                return RedirectToPage("Login");
            }

            return BadRequest();
        }

    }
}
