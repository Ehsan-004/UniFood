using UniFood.Data.Enum;

namespace UniFood.ViewModels;

public class StudentUserViewModel
{
    public int UniStudentId { get; set; }
    public string? ProfileImagePath { get; set; }
    public float Credit { get; set; } = 0;
    public EducationLevel EducationLevel { get; set; } = EducationLevel.Bachelor;
    public Major? Major { get; set; }
    public Faculty? Faculty { get; set; }

    public IEnumerable<EducationLevel> EducationLevels { get; set; }
    public IEnumerable<Major> Majors { get; set; }
    public IEnumerable<Faculty> Faculties { get; set; }

    // public ICollection<StudentReserve> StudentReserves { get; set; }
}