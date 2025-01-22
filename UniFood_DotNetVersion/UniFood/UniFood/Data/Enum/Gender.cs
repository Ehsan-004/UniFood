using System.ComponentModel.DataAnnotations;

namespace UniFood.Data.Enum;

public enum Gender
{
    [Display(Name = "آقا")]
    Male = 1,
    
    [Display(Name = "خانم")]
    Female = 2
}