using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ISubjectService
{

    /// <summary>
    /// Gets all subjects.
    /// </summary>
    /// <returns>List<SubjectDTO></returns>
    public List<SubjectDTO> GetAllSubjects();

    /// <summary>
    /// Gets the subject by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>SubjectDTO</returns>
    public SubjectDTO GetSubjectById(int id);
}
