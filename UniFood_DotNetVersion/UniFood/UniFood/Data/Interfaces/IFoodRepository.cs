using Microsoft.AspNetCore.Mvc;
using UniFood.Models;
using UniFood.Models.Context;

namespace UniFood.Data.Interfaces;

public interface IFoodRepository
{
    public IEnumerable<Food> GetFoods();
    public Food GetFood(int id);
    public  bool AddFood(Food food);
    public bool UpdateFood(Food food);
    public bool DeleteFood(int id);
    public bool Save();
}