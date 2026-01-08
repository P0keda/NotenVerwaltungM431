using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ISubjectService
{
    public List<SubjectDTO> GetAllSubjects();
    public SubjectDTO GetSubjectById(int id);
}
