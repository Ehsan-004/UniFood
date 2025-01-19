using Microsoft.AspNetCore.Identity;
using UniFood.Data.Interfaces;
using UniFood.Models;
using UniFood.Models.Context;

namespace UniFood.Data.Services;

public class StudentsRepository : IStudentsRepository
{
    private readonly UfContext _context;
    private readonly UserManager<Student> _userManager;

    public StudentsRepository(UfContext context, UserManager<Student> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public IEnumerable<Student> GetStudents()
    {
        return _context.Students.ToList();
    }

    public Student? GetStudentByUsername(string username)
    {
        return _context.Students.FirstOrDefault(s => s.UserName == username);
    }

    public Student GetStudentById(string id)
    {
        return _context.Students.FirstOrDefault(s => s.Id == id);
    }

    public bool AddStudent(Student student)
    {
        _context.Students.Add(student);
        return Save();
    }

    public bool UpdateStudent(Student student)
    {
        _context.Students.Update(student);
        return Save();
    }

    public bool DeleteStudent(string username)
    {
        var student = GetStudentByUsername(username);
        if (student != null)
        {
            _context.Students.Remove(student);
            return Save();
        }
        return false;
    }

    public bool Save()
    {
        return (_context.SaveChanges() >= 0);
    }
}