using System.ComponentModel.DataAnnotations;

namespace UniFood.Data.Enum;

public enum Major
{
    [Display(Name = "علوم کامپیوتر")]
    ComputerScience = 1,

    [Display(Name = "مهندسی مکانیک")]
    MechanicalEngineering = 2,

    [Display(Name = "مدیریت بازرگانی")]
    BusinessAdministration = 3,

    [Display(Name = "روان‌شناسی")]
    Psychology = 4,

    [Display(Name = "زیست‌شناسی")]
    Biology = 5,

    [Display(Name = "مهندسی برق")]
    ElectricalEngineering = 6,

    [Display(Name = "شیمی")]
    Chemistry = 7,

    [Display(Name = "مهندسی عمران")]
    CivilEngineering = 8,

    [Display(Name = "ریاضیات")]
    Mathematics = 9,

    [Display(Name = "علوم محیط زیست")]
    EnvironmentalScience = 10
}
