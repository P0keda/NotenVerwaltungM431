using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherService"/> class.
    /// </summary>
    /// <param name="teacherRepository">The teacher repository.</param>
    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    /// <inheritdoc />
    public List<TeacherDTO> GetAllTeachers()
    {
        IEnumerable<Teacher> TeachersFromDb = _teacherRepository.GetAllTeachers();
        List<TeacherDTO> TeachersToReturn = new List<TeacherDTO>();

        foreach (Teacher teacher in TeachersFromDb)
        {
            TeacherDTO teacherDTO = GetTeacherById(teacher.Id); 
            TeachersToReturn.Add(teacherDTO);
        }
        return TeachersToReturn;
    }

    /// <inheritdoc />
    public TeacherDTO GetTeacherById(int id)
    {
        Teacher teacher = _teacherRepository.GetTeacherById(id);

        TeacherDTO teacherDTO = new TeacherDTO
        {
            Id = teacher.Id,
            Name = teacher.FullName,
            Email = teacher.Email,
        };
        return teacherDTO;
    }

    /// <inheritdoc />
    public TeacherDTO GetTeacherByEmail(string email)
    {
        Teacher teacher = _teacherRepository.GetTeacherByEmail(email);

        TeacherDTO teacherDTO = new TeacherDTO
        {
            Id = teacher.Id,
            Name = teacher.FullName,
            Email = teacher.Email,
        };
        return teacherDTO;
    }
}
