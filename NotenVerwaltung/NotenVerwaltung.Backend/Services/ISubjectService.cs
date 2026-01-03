using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ISubjectService
{
    public List<SubjectDTO> GetAllSubjects();
}
