using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IGradeService
{
    /// <summary>
    /// Gets all grades.
    /// </summary>
    /// <returns>List<GradeDTO></returns>
    public List<GradeDTO> GetAllGrades();

    /// <summary>
    /// Gets the grade by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>GradeDTO</returns>
    public GradeDTO GetGradeById(int id);

    /// <summary>
    /// Gets the grade by student identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>List<GradeDTO></returns>
    public List<GradeDTO> GetGradeByStudentId(int id);

    /// <summary>
    /// Gets the grade by student identifier and subject identifier.
    /// </summary>
    /// <param name="studentId">The student identifier.</param>
    /// <param name="SubjectId">The subject identifier.</param>
    /// <returns>List<GradeDTO></returns>
    public List<GradeDTO> GetGradeByStudentIdAndSubjectId(int studentId, int SubjectId);

    /// <summary>
    /// Updates the grade.
    /// </summary>
    /// <param name="updateGradeDTO">The update grade dto.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>GradeDTO</returns>
    public GradeDTO UpdateGrade(UpdateGradeDTO updateGradeDTO, int id);
}
