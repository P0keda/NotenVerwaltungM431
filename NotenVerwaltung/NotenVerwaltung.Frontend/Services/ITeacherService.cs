using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services
{
    public interface ITeacherService
    {
        /// <summary>
        /// Gets all teachers asynchronous.
        /// </summary>
        /// <returns>TeacherDTO</returns>
        Task<List<TeacherDTO>> GetAllTeachersAsync();

        /// <summary>
        /// Gets the teacher by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>TeacherDTO</returns>
        Task<TeacherDTO?> GetTeacherByIdAsync(int id);
    }
}