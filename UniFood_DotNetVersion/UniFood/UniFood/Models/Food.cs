using UniFood.Data.Enum;

namespace UniFood.Models;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    
    public Day Day { get; set; }
    public bool IsActive { get; set; }
}