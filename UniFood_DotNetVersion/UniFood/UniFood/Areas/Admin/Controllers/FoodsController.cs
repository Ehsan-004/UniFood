using Microsoft.AspNetCore.Mvc;
using UniFood.Data.Interfaces;
using UniFood.Models;

namespace UniFood.Areas.Admin.Controllers;

[Area("Admin")]
public class FoodsController : Controller
{
    private readonly IFoodRepository _context;

    public FoodsController(IFoodRepository context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var foods = _context.GetFoods();
        return View(foods);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Food food)
    {
        if (!ModelState.IsValid) return View();

        if (_context.AddFood(food))
        {
            return RedirectToAction("index");
        }
        return View();
    }

    public IActionResult Edit(int id)
    {
        var url = _context.GetFood(id);
        return View(url);
    }

    [HttpPost]
    public IActionResult Edit(Food food)
    {
        if (!ModelState.IsValid) return View(food);
        
        _context.UpdateFood(food);
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(int id)
    {
        var food = _context.GetFood(id);
        return View(food);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _context.DeleteFood(id);
        return RedirectToAction("Index");
    }
}