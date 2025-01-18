using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using UniFood.Models;

namespace UniFood.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var isAuthenticated = HttpContext.User.Identity.IsAuthenticated;
        if (!isAuthenticated)
        {
            
        }
        return View();
    }

    [HttpGet]
    public IActionResult Reserve()
    {
        return View();
    }

    public IActionResult Test()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var userName = User.FindFirst(ClaimTypes.Name)?.Value;
        var isAuthenticated = User.Identity.IsAuthenticated;
        
        return Json(new { userId=userId,name=userName, isAuthenticated=isAuthenticated });
    }

public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}