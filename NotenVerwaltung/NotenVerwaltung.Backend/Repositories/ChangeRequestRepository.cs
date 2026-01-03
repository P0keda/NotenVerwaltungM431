using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class ChangeRequestRepository : IChangeRequestRepository
{
    private readonly AppDbContext _context;
    public ChangeRequestRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<ChangeRequest> GetAllChangeRequests()
    {
        return _context.changeRequests.ToList();
    }
}
