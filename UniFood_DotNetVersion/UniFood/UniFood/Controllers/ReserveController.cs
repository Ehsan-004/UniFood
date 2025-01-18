using Microsoft.AspNetCore.Mvc;

namespace UniFood.Controllers;

public class ReserveController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}