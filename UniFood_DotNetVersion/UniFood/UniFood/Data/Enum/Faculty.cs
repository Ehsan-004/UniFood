using System.ComponentModel.DataAnnotations;

namespace UniFood.Data.Enum;

public enum Faculty
{
    [Display(Name = "دانشکده مهندسی")]
    FacultyOfEngineering = 1,
    
    [Display(Name = "دانشکده علوم پایه")]
    FacultyOfScience = 2,
    
    [Display(Name = "دانشکده هنر")]
    FacultyOfArts = 3,

    [Display(Name = "دانشکده مدیریت و اقتصاد")]
    FacultyOfBusiness = 4,

    [Display(Name = "دانشکده پزشکی")]
    FacultyOfMedicine = 5,

    [Display(Name = "دانشکده حقوق")]
    FacultyOfLaw = 6,

    [Display(Name = "دانشکده علوم تربیتی")]
    FacultyOfEducation = 7,

    [Display(Name = "دانشکده علوم اجتماعی")]
    FacultyOfSocialSciences = 8,

    [Display(Name = "دانشکده کشاورزی")]
    FacultyOfAgriculture = 9,

    [Display(Name = "دانشکده معماری")]
    FacultyOfArchitecture = 10
}