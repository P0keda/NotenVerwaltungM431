using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IChangeRequestService
{
    public List<ChangeRequestDTO> GetAllChangeRequest();
}
