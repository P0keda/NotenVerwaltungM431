using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class SubjectService : ISubjectService
{
    private readonly ISubjectRepository _subjectRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IProrectorRepository _prorectorRepository;

    public SubjectService(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository, IProrectorRepository prorectorRepository)
    {
        _subjectRepository = subjectRepository;
        _teacherRepository = teacherRepository;
        _prorectorRepository = prorectorRepository;
    }
    public List<SubjectDTO> GetAllSubjects()
    {
        IEnumerable<Subject> SubjectsRepository = _subjectRepository.GetAllSubject();
        List<SubjectDTO> SubjectsToReturn = new List<SubjectDTO>();

        foreach (Subject subject in SubjectsRepository)
        {
            Teacher teacher = _teacherRepository.GetTeacherById(subject.TeacherId);
            Prorector prorector = _prorectorRepository.GetProrectorById(subject.ProrectorId);
            SubjectDTO subjectDTO = new SubjectDTO
            {
                Id = subject.Id,
                SubjectName = subject.SubjectName,
                TeacherId = subject.TeacherId,
                Teacher = new TeacherDTO
                {
                    Id = subject.TeacherId,
                    Name = teacher.FullName,
                    Email = teacher.Email,
                    Password = teacher.Password
                },
                ProrectorId = subject.ProrectorId,
                Prorector = new ProrectorDTO
                {
                    Id = subject.Id,
                    Email = prorector.Email,
                    Department = prorector.Department,
                    Name = prorector.fullName,
                    Password = prorector.Password
                }
            };
            SubjectsToReturn.Add(subjectDTO);
        }
        return SubjectsToReturn;
    }

    public SubjectDTO GetSubjectById(int id)
    {
        Subject Subject = _subjectRepository.GetSubjectById(id);
        Teacher Teacher = _teacherRepository.GetTeacherById(Subject.TeacherId);
        Prorector Prorector = _prorectorRepository.GetProrectorById(Subject.ProrectorId);

        SubjectDTO SubjectDTO = new SubjectDTO
        {
                Id = Subject.Id,
                SubjectName = Subject.SubjectName,
                TeacherId = Subject.TeacherId,
                Teacher = new TeacherDTO
                {
                    Id = Subject.TeacherId,
                    Name = Teacher.FullName,
                    Email = Teacher.Email,
                    Password = Teacher.Password
                },
                ProrectorId = Subject.ProrectorId,
                Prorector = new ProrectorDTO
                {
                    Id = Subject.Id,
                    Email = Prorector.Email,
                    Department = Prorector.Department,
                    Name = Prorector.fullName,
                    Password = Prorector.Password
                }
        };

        return SubjectDTO;
    }
}
