using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface ITeacherService
{
    public List<TeacherDTO> GetAllTeachers();
}
