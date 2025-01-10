﻿using UniFood.Data.Enum;

namespace UniFood.Models;

public class Student 
{
    public int Id { get; set; }
    public int UniStudentId { get; set; }
    public string ProfileImagePath { get; set; }
    public EducationLevel EducationLevel { get; set; } = EducationLevel.Bachelor;
    public float Credit { get; set; } = 0;
    public Major Major { get; set; }
    public Faculty Faculty { get; set; }
    
    public ICollection<StudentReserve> StudentReserves { get; set; }
}