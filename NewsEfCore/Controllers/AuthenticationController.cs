using Microsoft.AspNetCore.Mvc;
using NewsEfCore.Services.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IUserService _userService;

        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(InsertUserViewModel register)
        {
            if (!ModelState.IsValid)
                return View(register);

            _userService.Register(register);
            return View();
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginUserViewModel login)
        {
            if(!ModelState.IsValid)
                return View(login);

            _userService.LoginUser(login);
            return View("Register");
        }
            
    }
}
