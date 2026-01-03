using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;
    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }
    public Student GetStudentById(int id)
    {
        return _context.Students.FirstOrDefault(s => s.Id == id);
    }
}
