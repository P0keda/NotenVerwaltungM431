using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IChangeRequestRepository
{
    public List<ChangeRequest> GetAllChangeRequests();
}
