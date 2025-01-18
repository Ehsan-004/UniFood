using Microsoft.AspNetCore.Mvc;

namespace UniFood.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpGet]
    public IActionResult ResetPassword()
    {
        return View();
    }
}    