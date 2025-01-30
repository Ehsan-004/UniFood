using System.Security.AccessControl;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UniFood.Models;
using UniFood.Models.Context;
using UniFood.ViewModels;

namespace UniFood.Areas.Admin.Controllers;

// TODO: create an EditViewModel

[Area("Admin")]
public class StudentsController : Controller
{
    private readonly UserManager<Student> _context;
    private readonly ILogger<StudentsController> _logger;


    public StudentsController(UserManager<Student> context, ILogger<StudentsController> logger)
    {
        _context = context;
        _logger = logger;
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
    public async Task<IActionResult> Create(StudentUserViewModel studentViewModel)
    {
        if (!ModelState.IsValid)
        {
            foreach (var state in ModelState.Values)
            {
                foreach (var error in state.Errors)
                {
                    _logger.LogError($"Error Message: {error.ErrorMessage}");
                }
            }
            return View(studentViewModel);
        }

        var user = new Student()
        {
            EducationLevel = studentViewModel.EducationLevel,
            UniStudentId = studentViewModel.UniStudentId,
            UserName = studentViewModel.UniStudentId,
            FirstName = studentViewModel.FirstName,
            LastName = studentViewModel.LastName,
            Faculty = studentViewModel.Faculty,
            Gender = studentViewModel.Gender,
            Credit = studentViewModel.Credit,
            Major = studentViewModel.Major,
            DateOfBirth = studentViewModel.DateOfBirth,
        };
        
        var result = await _context.CreateAsync(user, studentViewModel.UniStudentId);
        
        _logger.LogInformation($"User is Admin {studentViewModel.IsAdmin}");

        if (studentViewModel.IsAdmin)
        {
            await _context.AddToRoleAsync(user, "Admin");
            _logger.LogInformation($"User is Admin {studentViewModel.IsAdmin}");
        }
        else
        {
            await _context.AddToRoleAsync(user, "Student");
            _logger.LogInformation($"User is Student ");
        }

        
        if (result.Succeeded)   
            return RedirectToAction("index");

        foreach (var error in result.Errors)
            _logger.LogError($"Code: {error.Code}, Description: {error.Description}");

        return RedirectToAction("Create");
    }
    
    public async Task<IActionResult> Edit(string username)
    {
        var student = await _context.FindByNameAsync(username);
        var studentViewModel = new StudentUserViewModel()
        {
            UniStudentId = student.UniStudentId,
            FirstName = student.FirstName,
            LastName = student.LastName,
            DateOfBirth = student.DateOfBirth,
            Gender = student.Gender,
            Major = student.Major,
            Faculty = student.Faculty,
            EducationLevel = student.EducationLevel,
        };
        return View(studentViewModel);
    }
    
    // [HttpPost]
    // public async Task<IActionResult> Edit(StudentUserViewModel studentViewModel)
    // {
    //     if (!ModelState.IsValid) return View(studentViewModel);
    //     
    //     var student = _context.FindByNameAsync(studentViewModel.UniStudentId);
    //     
    //     student.Major = studentViewModel.Major;
    //     
    //     var result = await _context.UpdateAsync(student);
    //     
    //     if (result.Succeeded)
    //         return RedirectToAction("Index"); 
    //     
    //     foreach (var error in result.Errors)
    //         _logger.LogError($"Code: {error.Code}, Description: {error.Description}");
    //
    //     return View(student);
    // }
    
    public async Task<IActionResult> Delete(string username)
    {
        var student = await _context.FindByNameAsync(username);
        return View(student);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(string username)
    {
        var student = await _context.FindByNameAsync(username);

        if (student == null)
        {
            return RedirectToAction("Delete", username);
        }
        
        var result = await _context.DeleteAsync(student);
        
        if (result.Succeeded)
            return RedirectToAction("Index");
        
        foreach (var error in result.Errors)
            _logger.LogError($"Code: {error.Code}, Description: {error.Description}");

        return RedirectToAction("Delete", student);
    }
}
