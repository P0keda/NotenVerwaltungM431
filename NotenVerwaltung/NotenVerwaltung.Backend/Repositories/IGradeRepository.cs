using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IGradeRepository
{
    public List<Grade> GetAllGrades();
    public Grade GetGradeById(int id);
}
