using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IGradeService
{
    public List<GradeDTO> GetAllGrades();
    public GradeDTO GetGradeById(int id);
    public List<GradeDTO> GetGradeByStudentId(int id);
    public List<GradeDTO> GetGradeByStudentIdAndSubjectId(int studentId, int SubjectId);
    public GradeDTO UpdateGrade(UpdateGradeDTO updateGradeDTO, int id);
}
