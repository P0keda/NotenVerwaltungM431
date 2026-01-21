using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface ITeacherRepository
{
    /// <summary>
    /// Gets all teachers.
    /// </summary>
    /// <returns>List<Teacher></returns>
    public List<Teacher> GetAllTeachers();

    /// <summary>
    /// Gets the teacher by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Teacher</returns>
    public Teacher GetTeacherById(int id);

    /// <summary>
    /// Gets the teacher by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>Teacher</returns>
    public Teacher GetTeacherByEmail(string email);

    /// <summary>
    /// Creates the teacher.
    /// </summary>
    /// <param name="teacher">The teacher.</param>
    /// <returns>Teacher</returns>
    public Teacher CreateTeacher(Teacher teacher);
}
