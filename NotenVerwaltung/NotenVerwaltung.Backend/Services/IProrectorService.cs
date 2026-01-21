using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IProrectorService
{
    /// <summary>
    /// Gets all prorectors.
    /// </summary>
    /// <returns>List<ProrectorDTO></returns>
    public List<ProrectorDTO> GetAllProrectors();

    /// <summary>
    /// Gets the prorector by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ProrectorDTO</returns>
    public ProrectorDTO GetProrectorById(int id);

    /// <summary>
    /// Gets the prorector by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>ProrectorDTO</returns>
    public ProrectorDTO GetProrectorByEmail(string email);
}
