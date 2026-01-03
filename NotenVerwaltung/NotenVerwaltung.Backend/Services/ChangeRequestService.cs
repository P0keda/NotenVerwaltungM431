using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;
using System.Diagnostics;

namespace NotenVerwaltung.Backend.Services;

public class ChangeRequestService : IChangeRequestService
{
    private readonly IChangeRequestRepository _changeRequestRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly ISubjectRepository _subjectRepository;
    private readonly IProrectorRepository _prorectorRepository;
    private readonly IStudentRepository _studentReposiory;

    private readonly IGradeRepository _gradeRepository;

    public ChangeRequestService(IChangeRequestRepository changeRequestRepository, ITeacherRepository teacherRepository,ISubjectRepository subjectRepository, IStudentRepository studentRepository, IProrectorRepository prorectorRepository, IGradeRepository gradeRepository)
    {
        _changeRequestRepository = changeRequestRepository;
        _subjectRepository = subjectRepository;
        _studentReposiory = studentRepository;
        _teacherRepository = teacherRepository;
        _prorectorRepository = prorectorRepository;
        _gradeRepository = gradeRepository;
    }
    public List<ChangeRequestDTO> GetAllChangeRequest()
    {
        IEnumerable<ChangeRequest> ChangeRequestRepository = _changeRequestRepository.GetAllChangeRequests();
        List<ChangeRequestDTO> changeRequestToReturn = new List<ChangeRequestDTO>();

        foreach (ChangeRequest changeRequest in ChangeRequestRepository)
        {
            Teacher teacher = _teacherRepository.GetTeacherById(changeRequest.TeacherId);
            Prorector prorector = _prorectorRepository.GetProrectorById(changeRequest.ProrectorId);
            Grade grade = _gradeRepository.GetGradeById(changeRequest.GradeId);
            Student student = _studentReposiory.GetStudentById(changeRequest.Grade.StudentId);
            Subject subject = _subjectRepository.GetSubjectById(changeRequest.Grade.SubjectId);

            ChangeRequestDTO changeRequestDTO = new ChangeRequestDTO
            {
                Id = changeRequest.Id,
                TeacherId = teacher.Id,
                Teacher = new TeacherDTO
                {
                    Id = teacher.Id,
                    Name = teacher.FullName,
                    Email = teacher.Email,
                    Password = teacher.Password
                },
                GradeId = grade.Id,
                Grade = new GradeDTO
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
                },
                ProrectorId = changeRequest.ProrectorId,
                Prorector = new ProrectorDTO
                {
                    Id = prorector.Id,
                    Name = prorector.fullName,
                    Department = prorector.Department,
                    Email = prorector.Email,
                    Password = prorector.Password
                },
                RequestedValue = changeRequest.RequestedValue,
                Reason = changeRequest.Reason,
                Status = changeRequest.Status,
                RequestedDate = changeRequest.RequestDate,
                DecisionDate = changeRequest.DecisionDate
            };
            changeRequestToReturn.Add(changeRequestDTO);
        }
        return changeRequestToReturn;
    }
}
