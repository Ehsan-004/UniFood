using System.ComponentModel.DataAnnotations;

namespace UniFood.Data.Enum;

public enum EducationLevel
{
    [Display(Name = "کارشناسی")]
    Bachelor = 'B',
    
    [Display(Name = "کارشناسی ارشد")]
    Masters = 'M',
    
    [Display(Name = "دکتری")]
    Phd = 'P'
}