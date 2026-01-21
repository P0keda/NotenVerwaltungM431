using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services;

public interface IProrectorService
{
    /// <summary>
    /// Gets all prorectors.
    /// </summary>
    /// <returns>List<ProrectorDTO></returns>
    public Task<List<ProrectorDTO>> GetAllProrectors();

    /// <summary>
    /// Gets the prorector by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ProrectorDTO</returns>
    public Task<ProrectorDTO> GetProrectorById(int id);

    /// <summary>
    /// Gets the prorector by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>ProrectorDTO</returns>
    public Task<ProrectorDTO> GetProrectorByEmail(string email);
}
