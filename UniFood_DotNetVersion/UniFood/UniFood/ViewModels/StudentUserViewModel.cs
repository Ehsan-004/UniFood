using System.ComponentModel.DataAnnotations;
using UniFood.Data.Enum;

namespace UniFood.ViewModels;

public class StudentUserViewModel
{
    [Display(Name = "نام")]
    public string FirstName { get; set; }
    
    [Display(Name = "نام خانوادگی")]
    public string LastName { get; set; }
    
    [Display(Name = "تاریخ تولد")]
    public DateTime DateOfBirth { get; set; }
    
    [Display(Name = "جنسیت")]
    public Gender Gender { get; set; }

    [Display(Name = "شماره دانشجویی")]
    public string UniStudentId { get; set; }
    
    [Display(Name = "تصویر پروفایل")]
    public string? ProfileImagePath { get; set; }
    
    [Display(Name = "میزان اعتبار")]
    public float Credit { get; set; } = 0;
    
    [Display(Name = "مفطع تحصیلی")]
    public EducationLevel EducationLevel { get; set; } = EducationLevel.Bachelor;
    
    [Display(Name = "رشته تحصیلی")]
    public Major Major { get; set; }
    
    [Display(Name = "دانشکده")]
    public Faculty Faculty { get; set; }

    [Display(Name = "ادمین است")] 
    public bool IsAdmin = false;
    
    //public IEnumerable<EducationLevel>? EducationLevels { get; set; }
    //public IEnumerable<Major>? Majors { get; set; }
    //public IEnumerable<Faculty>? Faculties { get; set; }

    // public ICollection<StudentReserve> StudentReserves { get; set; }
}