using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IProrectorRepository
{
    /// <summary>
    /// Gets all prorectors.
    /// </summary>
    /// <returns>List<Prorector></returns>
    public List<Prorector> GetAllProrectors();

    /// <summary>
    /// Gets the prorector by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Prorector</returns>
    public Prorector GetProrectorById(int id);

    /// <summary>
    /// Gets the prorector by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>Prorector</returns>
    public Prorector GetProrectorByEmail(string email);

    /// <summary>
    /// Creates the prorector.
    /// </summary>
    /// <param name="prorector">The prorector.</param>
    /// <returns>Prorector</returns>
    public Prorector CreateProrector(Prorector prorector);
}
