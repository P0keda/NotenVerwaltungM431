using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class ProrectorRepository : IProrectorRepository
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProrectorRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public ProrectorRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<Prorector> GetAllProrectors()
    {
        return _context.Prorectors.ToList();
    }

    /// <inheritdoc />
    public Prorector GetProrectorById(int id)
    {
        return _context.Prorectors.FirstOrDefault(p => p.Id == id);
    }

    /// <inheritdoc />
    public Prorector GetProrectorByEmail(string email)
    {
        return _context.Prorectors.FirstOrDefault(p => p.Email == email);
    }

    /// <inheritdoc />
    public Prorector CreateProrector(Prorector prorector)
    {
        _context.Prorectors.Add(prorector);
        _context.SaveChanges();
        return prorector;
    }
}
