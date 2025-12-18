using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly AppDbContext _context;
    public TeacherRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Teacher> GetAll()
    {
        return _context.Teachers
            .ToList();
    }

}
