using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class SubjectRepository : ISubjectRepository
{
    private readonly AppDbContext _context;
    public SubjectRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Subject> GetAllSubject()
    {
        return _context.Subjects.ToList();
    }

    public Subject GetSubjectById(int id)
    {
        return _context.Subjects.FirstOrDefault(s => s.Id == id);
    }
}
