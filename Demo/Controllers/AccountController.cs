using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        //BaseURL/Account/SignIn
        public IActionResult SignIn()
        {
            return View();
        }

        //BaseURL/Account/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
