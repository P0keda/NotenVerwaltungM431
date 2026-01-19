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
    public ChangeRequest CreateChangeRequest(ChangeRequest newchangeRequest)
    {
        _context.changeRequests.Add(newchangeRequest);
        _context.SaveChanges();
        return newchangeRequest;
    }
    public ChangeRequest GetChangeRequestById(int id)
    {
        return _context.changeRequests.FirstOrDefault(c => c.Id == id);
    }
    public ChangeRequest UpdateChangeRequestById(ChangeRequest updatedChangeRequest, int id)
    {
        ChangeRequest? existingChangeRequest = _context.changeRequests.FirstOrDefault(с => с.Id == id);
        if (existingChangeRequest == null)
        {
            return null;
        }
        existingChangeRequest.Status = updatedChangeRequest.Status;
        _context.SaveChanges();
        return existingChangeRequest;
    }
}
