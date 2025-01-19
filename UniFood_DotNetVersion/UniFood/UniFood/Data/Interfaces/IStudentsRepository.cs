using UniFood.Models;

namespace UniFood.Data.Interfaces;

public interface IStudentsRepository
{
    public IEnumerable<Student> GetStudents();
    public Student? GetStudentByUsername(string username);
    public Student GetStudentById(string id);
    public bool AddStudent(Student student);
    public bool UpdateStudent(Student student);
    public bool DeleteStudent(string username);
    public bool Save();
}