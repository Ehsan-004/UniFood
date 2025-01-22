using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using UniFood.Data.Enum;

namespace UniFood.Models;

public class Student : IdentityUser
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
    
    [Display(Name = "مفطع تحصیلی")]
    public EducationLevel EducationLevel { get; set; } = EducationLevel.Bachelor;
    
    [Display(Name = "میزان اعتبار")]
    public float Credit { get; set; } = 0;
    
    [Display(Name = "رشته تحصیلی")]
    public Major Major { get; set; }
    
    [Display(Name = "دانشکده")]
    public Faculty Faculty { get; set; }
    
    // public ICollection<StudentReserve> StudentReserves { get; set; }
}