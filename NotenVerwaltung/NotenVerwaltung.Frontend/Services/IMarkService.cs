using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services;

public interface IMarkService
{
    /// <summary>
    /// Gets the grades by student identifier asynchronous.
    /// </summary>
    /// <param name="studentId">The student identifier.</param>
    /// <returns>List<GradeDTO></returns>
    public Task<List<GradeDTO>> GetGradesByStudentIdAsync(int studentId);

    /// <summary>
    /// Gets all grades asynchronous.
    /// </summary>
    /// <returns>List<GradeDTO></returns>
    public Task<List<GradeDTO>> GetAllGradesAsync();

    /// <summary>
    /// Gets the grade by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>GradeDTO</returns>
    public Task<GradeDTO> GetGradeById(int id);
}
