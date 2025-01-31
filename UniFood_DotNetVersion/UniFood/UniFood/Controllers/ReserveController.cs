using Microsoft.AspNetCore.Mvc;
using UniFood.Data.Interfaces;

namespace UniFood.Controllers;

public class ReserveController : Controller
{
    private readonly IFoodRepository _foodRepository;

    public ReserveController(IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetFoods()
    {
        var foods = _foodRepository.GetFoods();
        var data = new
        {
            foods = foods
        };
        return Json(data);
    }
}