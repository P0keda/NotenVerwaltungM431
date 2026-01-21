using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class ChangeRequestService : IChangeRequestService
{
    private readonly IChangeRequestRepository _changeRequestRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IProrectorRepository _prorectorRepository;
    private readonly IGradeService _gradeService;
    private readonly IEmailService _emailService;

    private readonly IGradeRepository _gradeRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeRequestService"/> class.
    /// </summary>
    /// <param name="gradeService">The grade service.</param>
    /// <param name="changeRequestRepository">The change request repository.</param>
    /// <param name="teacherRepository">The teacher repository.</param>
    /// <param name="prorectorRepository">The prorector repository.</param>
    /// <param name="gradeRepository">The grade repository.</param>
    /// <param name="emailService">The email service.</param>
    public ChangeRequestService(IGradeService gradeService, IChangeRequestRepository changeRequestRepository, ITeacherRepository teacherRepository, IProrectorRepository prorectorRepository, IGradeRepository gradeRepository, IEmailService emailService)
    {
        _gradeService = gradeService;
        _changeRequestRepository = changeRequestRepository;
        _teacherRepository = teacherRepository;
        _prorectorRepository = prorectorRepository;
        _gradeRepository = gradeRepository;
        _emailService = emailService;
    }

    /// <inheritdoc />
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

        ChangeRequest createdChangeRequest = _changeRequestRepository.CreateChangeRequest(changeRequest);

        _emailService.SendAsync(createdChangeRequest.Prorector.Email, "Neue Antrag für Note Änderung", $"Neue Antrag von {createdChangeRequest.Teacher.FullName} wurde erstellt. \nGrund für diese Änderung ist {createdChangeRequest.Reason}");
        return GetChangeRequestById(changeRequest.Id);
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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
            },

            Grade = _gradeService.GetGradeById(grade.Id),

            Prorector = new ProrectorDTO
            {
                Id = prorector.Id,
                Name = prorector.fullName,
                Department = prorector.Department,
                Email = prorector.Email,
            },

            RequestedValue = changeRequest.RequestedValue,
            Reason = changeRequest.Reason,
            Status = changeRequest.Status,
            RequestedDate = changeRequest.RequestDate,
            DecisionDate = changeRequest.DecisionDate
        };
    }

    /// <inheritdoc />
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
