using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UniFood.Models;
using UniFood.Models.Context;
using UniFood.ViewModels;

namespace UniFood.Areas.Admin.Controllers;

[Area("Admin")]
public class StudentsController : Controller
{
    private readonly UserManager<Student> _context;

    public StudentsController(UserManager<Student> context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var students = _context.Users.ToList();
        return View(students);
    }

    public IActionResult Create()
    {
        var studentViewModel = new StudentUserViewModel();
        return View(studentViewModel);
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid) return View();
    
        
        {
            return RedirectToAction("index");
        }
        return View();
    }
}