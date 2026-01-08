using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<StudentDTO> GetAllStudents()
    {
        List<Student> students = _studentRepository.GetAllStudents();

        List<StudentDTO> StudentsToReturn = new List<StudentDTO>();

        foreach (Student student in students)
        {
            StudentDTO studentDTO = GetStudentById(student.Id);
            StudentsToReturn.Add(studentDTO);
        }
        return StudentsToReturn;
    }

    public StudentDTO GetStudentById(int id)
    {
        Student student = _studentRepository.GetStudentById(id);

        StudentDTO studentDTO = new StudentDTO
        {
                Id = student.Id,
                Name = student.fullName,
                Class = student.className
        };

        return studentDTO;
    }
}
