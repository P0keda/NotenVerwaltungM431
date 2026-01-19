using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IGradeRepository
{
    public List<Grade> GetAllGrades();
    public Grade GetGradeById(int id);

    public List<Grade> GetGradeByStudentId(int id);
    public List<Grade> GetGradeByStudentIdAndSubject(int studentId, int subjectId);
    public Grade UpdateGrade(Grade updatedGrade, int id);
}
