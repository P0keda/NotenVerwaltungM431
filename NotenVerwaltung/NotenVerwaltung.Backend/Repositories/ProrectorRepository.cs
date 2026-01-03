using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class ProrectorRepository : IProrectorRepository
{
    private readonly AppDbContext _context;
    public ProrectorRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Prorector> GetAllProrectors()
    {
        return _context.Prorectors.ToList();
    }

    public Prorector GetProrectorById(int id)
    {
        return _context.Prorectors.FirstOrDefault(p => p.Id == id);
    }
}
