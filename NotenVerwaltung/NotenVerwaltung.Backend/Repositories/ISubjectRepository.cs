using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface ISubjectRepository
{
    public List<Subject> GetAllSubject();
    public Subject GetSubjectById(int id);
}
