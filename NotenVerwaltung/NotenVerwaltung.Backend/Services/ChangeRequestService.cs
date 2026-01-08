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
    private readonly IGradeService _gradeService;

    private readonly IGradeRepository _gradeRepository;

    public ChangeRequestService(IGradeService gradeService, IChangeRequestRepository changeRequestRepository, ITeacherRepository teacherRepository,ISubjectRepository subjectRepository, IStudentRepository studentRepository, IProrectorRepository prorectorRepository, IGradeRepository gradeRepository)
    {
        _gradeService = gradeService;
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
                Teacher = new TeacherDTO
                {
                    Id = teacher.Id,
                    Name = teacher.FullName,
                    Email = teacher.Email,
                    Password = teacher.Password
                },
                Grade = _gradeService.GetGradeById(grade.Id),
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
