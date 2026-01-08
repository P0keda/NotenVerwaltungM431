using NotenVerwaltung.Frontend.DTOs;

namespace NotenVerwaltung.Frontend.Services
{
    public interface ITeacherService
    {
        Task<IEnumerable<TeacherDTO>> GetAllTeachersAsync();
        Task<TeacherDTO?> GetTeacherByIdAsync(int id);
        Task<TeacherDTO> CreateTeacherAsync(TeacherDTO teacherDto);
    }
}