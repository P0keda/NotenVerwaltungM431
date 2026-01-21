using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="StudentRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    /// <inheritdoc />
    public Student GetStudentById(int id)
    {
        return _context.Students.FirstOrDefault(s => s.Id == id);
    }
}
