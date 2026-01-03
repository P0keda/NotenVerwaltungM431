using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }
    public List<TeacherDTO> GetAllTeachers()
    {
        IEnumerable<Teacher> TeachersFromDb = _teacherRepository.GetAllTeachers();
        List<TeacherDTO> TeachersToReturn = new List<TeacherDTO>();

        foreach (Teacher teacher in TeachersFromDb)
        {
            TeacherDTO teacherDTO = new TeacherDTO
            {
                Id = teacher.Id,
                Name = teacher.FullName,
                Email = teacher.Email,
                Password = teacher.Password
            };
            TeachersToReturn.Add(teacherDTO);
        }
        return TeachersToReturn;
    }

}
