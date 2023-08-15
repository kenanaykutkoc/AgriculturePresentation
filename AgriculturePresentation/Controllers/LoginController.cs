using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public LoginController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            IdentityUser identityUser = new IdentityUser()
            {
                Id="Id",
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Mail
            };
            if (registerViewModel.Password == registerViewModel.PasswordConfirm)
            {
                var result = await _userManager.CreateAsync(identityUser, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerViewModel);
        }


    }
}
