using System.ComponentModel.DataAnnotations;
using UniFood.Data.Enum;

namespace UniFood.Models;

public class Food
{
    public int Id { get; set; }
    [Display(Name = ("نام غذا"))] public string Name { get; set; }
    [Display(Name = "قیمت غذا")]

    public float Price { get; set; }
    [Display(Name = "روز ارائه غذا")]
    
    public Day Day { get; set; }
    [Display(Name = "غذا ارائه میشود؟")]
    public bool IsActive { get; set; }
}