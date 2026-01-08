using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IStudentService
{
    public List<StudentDTO> GetAllStudents();
    public StudentDTO GetStudentById(int id);
}
