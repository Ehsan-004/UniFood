using System.ComponentModel.DataAnnotations;

namespace UniFood.Data.Enum;

public enum Day
{
    [Display(Name = "شنبه")]
    Saturday = 0,
    
    [Display(Name = "یکشنبه")]
    Sunday = 1,
    
    [Display(Name = "دوشنبه")]
    Monday = 2,
    
    [Display(Name = "سه شنبه")]
    Tuesday = 3,
    
    [Display(Name = "جهارشنبه")]
    Wednesday = 4,
    
    [Display(Name = "پنچ شنبه")]
    Thursday = 5,
    
    [Display(Name = "جمعه")]
    Friday = 6,
}