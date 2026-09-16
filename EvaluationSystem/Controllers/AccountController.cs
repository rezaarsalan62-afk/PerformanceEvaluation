using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EvaluationSystem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // کاربران آزمایشی
            if (username == "user1" && password == "1")
            {
                await SignInUser(username);
                return RedirectToAction("Index", "Home");
            }

            if (username == "user2" && password == "2")
            {
                await SignInUser(username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "نام کاربری یا رمز عبور اشتباه است.";
            return View();
        }

        private async Task SignInUser(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username)
            };

            var identity = new ClaimsIdentity(
                claims,
                "CookieAuth");

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                "CookieAuth",
                principal);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuth");

            return RedirectToAction("Login", "Account");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}