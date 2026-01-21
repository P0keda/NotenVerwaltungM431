using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IStudentService
{

    /// <summary>
    /// Gets all students.
    /// </summary>
    /// <returns>List<StudentDTO></returns>
    public List<StudentDTO> GetAllStudents();

    /// <summary>
    /// Gets the student by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>StudentDTO</returns>
    public StudentDTO GetStudentById(int id);
}
