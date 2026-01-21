using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IChangeRequestRepository
{
    /// <summary>
    /// Gets all change requests.
    /// </summary>
    /// <returns>List<ChangeRequest></returns>
    public List<ChangeRequest> GetAllChangeRequests();

    /// <summary>
    /// Gets the change request by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ChangeRequest</returns>
    public ChangeRequest GetChangeRequestById(int id);

    /// <summary>
    /// Creates the change request.
    /// </summary>
    /// <param name="newchangeRequest">The newchange request.</param>
    /// <returns>ChangeRequest</returns>
    public ChangeRequest CreateChangeRequest(ChangeRequest newchangeRequest);

    /// <summary>
    /// Updates the change request by identifier.
    /// </summary>
    /// <param name="updatedChangeRequest">The updated change request.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>ChangeRequest</returns>
    public ChangeRequest UpdateChangeRequestById(ChangeRequest updatedChangeRequest, int id);
}
