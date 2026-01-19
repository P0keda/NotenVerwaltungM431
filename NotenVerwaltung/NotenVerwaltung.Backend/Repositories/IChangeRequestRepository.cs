using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IChangeRequestRepository
{
    public List<ChangeRequest> GetAllChangeRequests();
    public ChangeRequest GetChangeRequestById(int id);
    public ChangeRequest CreateChangeRequest(ChangeRequest newchangeRequest);
    public ChangeRequest UpdateChangeRequestById(ChangeRequest updatedChangeRequest, int id);
}
