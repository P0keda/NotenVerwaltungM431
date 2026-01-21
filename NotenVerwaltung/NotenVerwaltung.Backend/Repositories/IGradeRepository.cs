using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IGradeRepository
{
    /// <summary>
    /// Gets all grades.
    /// </summary>
    /// <returns>List<Grade></returns>
    public List<Grade> GetAllGrades();

    /// <summary>
    /// Gets the grade by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Grade</returns>
    public Grade GetGradeById(int id);

    /// <summary>
    /// Gets the grade by student identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>List<Grade></returns>
    public List<Grade> GetGradeByStudentId(int id);

    /// <summary>
    /// Gets the grade by student identifier and subject.
    /// </summary>
    /// <param name="studentId">The student identifier.</param>
    /// <param name="subjectId">The subject identifier.</param>
    /// <returns>List<Grade></returns>
    public List<Grade> GetGradeByStudentIdAndSubject(int studentId, int subjectId);

    /// <summary>
    /// Updates the grade.
    /// </summary>
    /// <param name="updatedGrade">The updated grade.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>Grade</returns>
    public Grade UpdateGrade(Grade updatedGrade, int id);
}
