using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services;

public interface IMarkAdjustmentService
{
    /// <summary>
    /// Gets all change requests.
    /// </summary>
    /// <returns>List<ChangeRequestDTO></returns>
    public Task<List<ChangeRequestDTO>> GetAllChangeRequests();

    /// <summary>
    /// Gets the change request by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ChangeRequestDTO</returns>
    public Task<ChangeRequestDTO> GetChangeRequestById(int id);

    /// <summary>
    /// Creates the change request.
    /// </summary>
    /// <param name="newchangeRequest">The newchange request.</param>
    /// <returns>Task</returns>
    public Task CreateChangeRequest(CreateChangeRequestDTO newchangeRequest);

    /// <summary>
    /// Updates the change request by identifier.
    /// </summary>
    /// <param name="updatedChangeRequest">The updated change request.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>UpdateChangeRequestDTO</returns>
    public Task<UpdateChangeRequestDTO> UpdateChangeRequestById(UpdateChangeRequestDTO updatedChangeRequest, int id);
}
