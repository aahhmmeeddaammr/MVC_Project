using App.DAL.Models;
using App.PL.Helpers;
using App.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App.PL.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async  Task< IActionResult> SingUp(SignUpViewModel signUpViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Fname = signUpViewModel.Fname,
                    Email = signUpViewModel.Email,
                    UserName = signUpViewModel.Email.Split('@')[0],
                    isAgree = signUpViewModel.IsAgree,

                };
                var result = await userManager.CreateAsync(user, signUpViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }
                foreach (var Error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, Error.Description);
                }
            }
            return View(signUpViewModel);
        }
        public IActionResult Login()
        {
            return View("SignIn");
        }

        [HttpPost]
		public async Task<IActionResult> Login(SignInViewModel signInViewModel)
		{
			if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(signInViewModel.Email);
                if (user != null) {
                    bool flag = await userManager.CheckPasswordAsync(user, signInViewModel.Password);
                    if (flag)
                    {
                        var result =await signInManager.PasswordSignInAsync(user, signInViewModel.Password, signInViewModel.Rememberme,true);
                        if (result.Succeeded)
                        {
						    return RedirectToAction("Index", "Home");
                        }
					}
				}
            }

            return View("SignIn",signInViewModel);
		}

        public  async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }


        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]

		public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel model)
		{
			if (!ModelState.IsValid)
				return View(model);  // Early return to avoid nested conditions

			var user = await userManager.FindByEmailAsync(model.Email);
			if (user == null)
				return View(model);  // Return same view to avoid exposing that the email doesn't exist

			var token = await userManager.GeneratePasswordResetTokenAsync(user);
			var callbackUrl = Url.Action(
				"ResetPassword", "Account",
				new { email = model.Email, token },
				protocol: Request.Scheme); // Ensure full URL

			var email = new Email
			{
				Body = $"Please reset your password by clicking this link: {callbackUrl}",
				Subject = "Reset Password",
				To = model.Email
			};

            email.SendEmail();// Ensure sendEmail is awaited if it's async

			return RedirectToAction(nameof(CheckYouInbox));
		}

		public IActionResult CheckYouInbox()
        {
            return View();
        }
        public IActionResult ResetPassword(string email , string token)
        {
            TempData["Token"] = token;
            TempData["email"] = email;

			return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid) {
                var user = await userManager.FindByEmailAsync((string)TempData["email"]);
                if (user != null)
                {
                    var result =  await userManager.ResetPasswordAsync(user, (string)TempData["Token"], model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                }
            }
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
