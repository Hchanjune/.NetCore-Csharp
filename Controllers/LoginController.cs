using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

public class LoginController : Controller
{
        public IActionResult Login()
    {
        var model = new LoginViewModel
        {
            Message = "Sign In Now!"
        };
        return View(model);
    }
}