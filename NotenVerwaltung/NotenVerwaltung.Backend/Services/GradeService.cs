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

    /// <summary>
    /// Initializes a new instance of the <see cref="GradeService"/> class.
    /// </summary>
    /// <param name="subjectRepository">The subject repository.</param>
    /// <param name="teacherRepository">The teacher repository.</param>
    /// <param name="studentRepository">The student repository.</param>
    /// <param name="prorectorRepository">The prorector repository.</param>
    /// <param name="gradeRepository">The grade repository.</param>
    public GradeService(ISubjectRepository subjectRepository, ITeacherRepository teacherRepository,IStudentRepository studentRepository, IProrectorRepository prorectorRepository, IGradeRepository gradeRepository)
    {
        _subjectRepository = subjectRepository;
        _teacherRepository = teacherRepository;
        _studentReposiory = studentRepository;
        _prorectorRepository = prorectorRepository;
        _gradeRepository = gradeRepository;
    }

    /// <inheritdoc />
    public List<GradeDTO> GetAllGrades()
    {
        List<Grade> GradesRepository = _gradeRepository.GetAllGrades();
        List<GradeDTO> GradesToReturn = new List<GradeDTO>();

        foreach (Grade grade in GradesRepository)
        {
            GradeDTO gradeDTO = GetGradeById(grade.Id);
            GradesToReturn.Add(gradeDTO);
        }
        return GradesToReturn;
    }

    /// <inheritdoc />
    public GradeDTO GetGradeById(int id)
    {
        Grade grade = _gradeRepository.GetGradeById(id);

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
                    }
                },
            };
        return gradeDTO;
    }

    /// <inheritdoc />
    public List<GradeDTO> GetGradeByStudentId(int id)
    {
        List<Grade> GradesRepository = _gradeRepository.GetGradeByStudentId(id);
        List<GradeDTO> GradesToReturn = new List<GradeDTO>();

        foreach (Grade grade in GradesRepository)
        {
            GradeDTO gradeDTO = GetGradeById(grade.Id);
            GradesToReturn.Add(gradeDTO);
        }
        return GradesToReturn;
    }

    /// <inheritdoc />
    public List<GradeDTO> GetGradeByStudentIdAndSubjectId(int studentId, int SubjectId)
    {
        List<Grade> GradesRepository = _gradeRepository.GetGradeByStudentIdAndSubject(studentId, SubjectId);
        List<GradeDTO> GradesToReturn = new List<GradeDTO>();

        foreach (Grade grade in GradesRepository)
        {
            GradeDTO gradeDTO = GetGradeById(grade.Id);
            GradesToReturn.Add(gradeDTO);
        }
        return GradesToReturn;
    }

    /// <inheritdoc />
    public GradeDTO UpdateGrade(UpdateGradeDTO updateGradeDTO, int id)
    {
        Grade grade = _gradeRepository.GetGradeById(id);
        if (grade == null)
        {
            return null;
        }
        grade.GradeValue = updateGradeDTO.GradeValue;
        grade.Comment = updateGradeDTO.Comment;
        _gradeRepository.UpdateGrade(grade, id);
        GradeDTO gradeDTO = GetGradeById(grade.Id);
        return gradeDTO;
    }
}
