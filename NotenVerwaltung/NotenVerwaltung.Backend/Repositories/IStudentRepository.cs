using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IStudentRepository
{
    /// <summary>
    /// Gets all students.
    /// </summary>
    /// <returns>List<Student></returns>
    public List<Student> GetAllStudents();

    /// <summary>
    /// Gets the student by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Student</returns>
    public Student GetStudentById(int id);
}
