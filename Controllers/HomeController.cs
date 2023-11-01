using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Message = " Hello! Welcome "
        };
        return View(model);
    }
}