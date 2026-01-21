using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class SubjectRepository : ISubjectRepository
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public SubjectRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<Subject> GetAllSubject()
    {
        return _context.Subjects.ToList();
    }

    /// <inheritdoc />
    public Subject GetSubjectById(int id)
    {
        return _context.Subjects.FirstOrDefault(s => s.Id == id);
    }
}
