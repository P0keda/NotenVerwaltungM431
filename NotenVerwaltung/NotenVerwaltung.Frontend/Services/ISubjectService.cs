using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services;

public interface ISubjectService
{
    /// <summary>
    /// Gets all subjects.
    /// </summary>
    /// <returns>List<SubjectDTO></returns>
    public Task<List<SubjectDTO>> GetAllSubjects();

    /// <summary>
    /// Gets the subject by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>SubjectDTO</returns>
    public Task<SubjectDTO> GetSubjectById(int id);
}
