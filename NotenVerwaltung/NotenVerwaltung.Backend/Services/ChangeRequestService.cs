using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

    public ChangeRequestDTO CreateChangeRequest(CreateChangeRequestDTO createChangeRequestDTO)
    {
        Grade grade = _gradeRepository.GetGradeById(createChangeRequestDTO.GradeId);

        Teacher teacher = _teacherRepository.GetTeacherById(createChangeRequestDTO.TeacherId);

        Prorector prorector = _prorectorRepository.GetProrectorById(createChangeRequestDTO.ProrectorId);

        ChangeRequest changeRequest = new ChangeRequest
        {
            GradeId = createChangeRequestDTO.GradeId,
            TeacherId = createChangeRequestDTO.TeacherId,
            ProrectorId = createChangeRequestDTO.ProrectorId,
            RequestedValue = createChangeRequestDTO.RequestedValue,
            Reason = createChangeRequestDTO.Reason,
            Status = RequestStatus.pending,
            RequestDate = DateOnly.FromDateTime(DateTime.UtcNow)
        };

        _changeRequestRepository.CreateChangeRequest(changeRequest);

        return GetChangeRequestById(changeRequest.Id);
    }

    public List<ChangeRequestDTO> GetAllChangeRequest()
    {
        IEnumerable<ChangeRequest> ChangeRequestRepository = _changeRequestRepository.GetAllChangeRequests();
        List<ChangeRequestDTO> changeRequestToReturn = new List<ChangeRequestDTO>();

        foreach (ChangeRequest changeRequest in ChangeRequestRepository)
        {
            ChangeRequestDTO changeRequestDTO = GetChangeRequestById(changeRequest.Id);
            changeRequestToReturn.Add(changeRequestDTO);
        }
        return changeRequestToReturn;
    }

    public ChangeRequestDTO GetChangeRequestById(int id)
    {
        ChangeRequest changeRequest = _changeRequestRepository.GetChangeRequestById(id);

        Teacher teacher = _teacherRepository.GetTeacherById(changeRequest.TeacherId);
        Prorector prorector = _prorectorRepository.GetProrectorById(changeRequest.ProrectorId);
        Grade grade = _gradeRepository.GetGradeById(changeRequest.GradeId);

        return new ChangeRequestDTO
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
    }

    public ChangeRequestDTO UpdateChangeRequestById(UpdateChangeRequestDTO updateChangeRequestDTO, int id)
    {
        ChangeRequest changeRequest = _changeRequestRepository.GetChangeRequestById(id);

        changeRequest.Status = updateChangeRequestDTO.Status;
        changeRequest.DecisionDate = DateOnly.FromDateTime(DateTime.UtcNow);

        ChangeRequest updatedChangeRequest = _changeRequestRepository.UpdateChangeRequestById(changeRequest, id);

        if (updatedChangeRequest.Status == RequestStatus.approved)
        {
            UpdateGradeDTO updateGradeDTO = new UpdateGradeDTO
            {
                GradeValue = updatedChangeRequest.RequestedValue,
                Comment = updatedChangeRequest.Reason
            };
            _gradeService.UpdateGrade(updateGradeDTO, updatedChangeRequest.GradeId);
        }

        return GetChangeRequestById(id);
    }
}
