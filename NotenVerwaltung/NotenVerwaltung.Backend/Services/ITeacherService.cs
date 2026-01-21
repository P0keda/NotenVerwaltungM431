using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ITeacherService
{
    /// <summary>
    /// Gets all teachers.
    /// </summary>
    /// <returns>List<TeacherDTO></returns>
    public List<TeacherDTO> GetAllTeachers();

    /// <summary>
    /// Gets the teacher by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>TeacherDTO</returns>
    public TeacherDTO GetTeacherById(int id);

    /// <summary>
    /// Gets the teacher by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>TeacherDTO</returns>
    public TeacherDTO GetTeacherByEmail(string email);
}
