using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface ISubjectRepository
{
    /// <summary>
    /// Gets all subject.
    /// </summary>
    /// <returns>List<Subject></returns>
    public List<Subject> GetAllSubject();

    /// <summary>
    /// Gets the subject by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Subject</returns>
    public Subject GetSubjectById(int id);
}
