using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IChangeRequestService
{
    public List<ChangeRequestDTO> GetAllChangeRequest();

    public ChangeRequestDTO GetChangeRequestById(int id);
    public ChangeRequestDTO CreateChangeRequest(CreateChangeRequestDTO createChangeRequestDTO);
    public ChangeRequestDTO UpdateChangeRequestById(UpdateChangeRequestDTO updateChangeRequestDTO, int id);
}
