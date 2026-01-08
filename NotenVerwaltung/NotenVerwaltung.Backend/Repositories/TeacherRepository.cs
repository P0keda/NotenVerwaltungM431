using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly AppDbContext _context;
    public TeacherRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Teacher> GetAllTeachers()
    {
        return _context.Teachers.ToList();
    }

    public Teacher GetTeacherById(int id)
    {
        return _context.Teachers.FirstOrDefault(t => t.Id == id);
    }

    public Teacher GetTeacherByEmail(string email)
    {
        return _context.Teachers.FirstOrDefault(t => t.Email == email);
    }
}
