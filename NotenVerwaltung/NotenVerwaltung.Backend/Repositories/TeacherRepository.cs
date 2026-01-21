using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public TeacherRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<Teacher> GetAllTeachers()
    {
        return _context.Teachers.ToList();
    }

    /// <inheritdoc />
    public Teacher GetTeacherById(int id)
    {
        return _context.Teachers.FirstOrDefault(t => t.Id == id);
    }

    /// <inheritdoc />
    public Teacher GetTeacherByEmail(string email)
    {
        return _context.Teachers.FirstOrDefault(t => t.Email == email);
    }

    /// <inheritdoc />
    public Teacher CreateTeacher(Teacher teacher)
    {
        _context.Teachers.Add(teacher);
        _context.SaveChanges();
        return teacher;
    }
}
