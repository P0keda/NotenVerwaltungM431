using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ITeacherService
{
    public List<TeacherDTO> GetAllTeachers();
    public TeacherDTO GetTeacherById(int id);
    public TeacherDTO GetTeacherByEmail(string email);
}
