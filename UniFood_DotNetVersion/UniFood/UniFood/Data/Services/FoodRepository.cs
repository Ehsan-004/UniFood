using UniFood.Data.Interfaces;
using UniFood.Models;
using UniFood.Models.Context;

namespace UniFood.Data.Services;

public class FoodRepository : IFoodRepository
{
    private readonly UfContext _context;

    public FoodRepository(UfContext context)
    {
        _context = context;
    }

    public IEnumerable<Food> GetFoods()
    {
        return _context.Foods.ToList();
    }

    public Food GetFood(int id)
    {
        return _context.Foods.FirstOrDefault(f => f.Id == id);
    }

    public bool AddFood(Food food)
    {
        _context.Foods.Add(food);
        return Save();
    }

    public bool UpdateFood(Food food)
    {
        _context.Foods.Update(food);
        return Save();
    }

    public bool DeleteFood(int id)
    {
        var food = GetFood(id);
        if (food != null)
        {
            _context.Foods.Remove(food);
            return Save();
        }
        return false;
    }

    public bool Save()
    {
        return (_context.SaveChanges() >= 0);
    }
}