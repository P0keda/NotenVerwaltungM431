using NotenVerwaltung.Shared.DTOs;
using static System.Net.WebRequestMethods;

namespace NotenVerwaltung.Frontend.Services;

public interface IStudentService
{
    /// <summary>
    /// Gets all asynchronous.
    /// </summary>
    /// <returns>StudentDTO</returns>
    public Task<List<StudentDTO>> GetAllAsync();

    /// <summary>
    /// Gets the by identifier asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>StudentDTO</returns>
    public Task<StudentDTO?> GetByIdAsync(int id);
}
