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
    public Prorector GetProrectorByEmail(string email)
    {
        return _context.Prorectors.FirstOrDefault(p => p.Email == email);
    }

    public Prorector CreateProrector(Prorector prorector)
    {
        _context.Prorectors.Add(prorector);
        _context.SaveChanges();
        return prorector;
    }
}
