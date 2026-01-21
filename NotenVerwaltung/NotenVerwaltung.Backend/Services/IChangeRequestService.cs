using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IChangeRequestService
{
    /// <summary>
    /// Gets all change request.
    /// </summary>
    /// <returns>List<ChangeRequestDTO></returns>
    public List<ChangeRequestDTO> GetAllChangeRequest();

    /// <summary>
    /// Gets the change request by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ChangeRequestDTO</returns>
    public ChangeRequestDTO GetChangeRequestById(int id);

    /// <summary>
    /// Creates the change request.
    /// </summary>
    /// <param name="createChangeRequestDTO">The create change request dto.</param>
    /// <returns>ChangeRequestDTO</returns>
    public ChangeRequestDTO CreateChangeRequest(CreateChangeRequestDTO createChangeRequestDTO);

    /// <summary>
    /// Updates the change request by identifier.
    /// </summary>
    /// <param name="updateChangeRequestDTO">The update change request dto.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>ChangeRequestDTO</returns>
    public ChangeRequestDTO UpdateChangeRequestById(UpdateChangeRequestDTO updateChangeRequestDTO, int id);
}
