using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class GradeService : IGradeService
{
    private readonly ISubjectRepository _subjectRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IStudentRepository _studentReposiory;
    private readonly IProrectorRepository _prorectorRepository;
    private readonly IGradeRepository _gradeRepository;

    public GradeService(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository,IStudentRepository studentRepository, IProrectorRepository prorectorRepository, IGradeRepository gradeRepository)
    {
        _subjectRepository = subjectRepository;
        _teacherRepository = teacherRepository;
        _studentReposiory = studentRepository;
        _prorectorRepository = prorectorRepository;
        _gradeRepository = gradeRepository;
    }
    public List<GradeDTO> GetAllGrades()
    {
        IEnumerable<Grade> GradesRepository = _gradeRepository.GetAllGrades();
        List<GradeDTO> GradesToReturn = new List<GradeDTO>();

        foreach (Grade grade in GradesRepository)
        {
            Teacher teacher = _teacherRepository.GetTeacherById(grade.TeacherId);
            Student student = _studentReposiory.GetStudentById(grade.StudentId);
            Subject subject = _subjectRepository.GetSubjectById(grade.SubjectId);
            Prorector prorector = _prorectorRepository.GetProrectorById(grade.Subject.ProrectorId);
            GradeDTO gradeDTO = new GradeDTO
            {
                Id = grade.Id,
                Date = grade.GradeDate,
                Comment = grade.Comment,
                GradeValue = grade.GradeValue,
                StudentId = student.Id,
                Student = new StudentDTO
                {
                    Id = student.Id,
                    Class = student.className,
                    Name = student.fullName
                },
                TeacherId = teacher.Id,
                Teacher = new TeacherDTO
                {
                    Id = subject.TeacherId,
                    Name = teacher.FullName,
                    Email = teacher.Email,
                    Password = teacher.Password
                },
                SubjectId = subject.Id,
                Subject = new SubjectDTO
                {
                    Id = subject.Id,
                    SubjectName = subject.SubjectName,
                    ProrectorId = prorector.Id,
                    Prorector = new ProrectorDTO
                    {
                        Id = prorector.Id,
                        Email = prorector.Email,
                        Department = prorector.Department,
                        Name = prorector.fullName,
                        Password = prorector.Password
                    }
                },
            };
            GradesToReturn.Add(gradeDTO);
        }
        return GradesToReturn;
    }
}
