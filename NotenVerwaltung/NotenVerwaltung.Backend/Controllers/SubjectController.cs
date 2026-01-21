using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubjectController : ControllerBase
{
    private readonly ISubjectService _subjectService;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectController"/> class.
    /// </summary>
    /// <param name="subjectService">The subject service.</param>
    public SubjectController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    /// <summary>
    /// Gets all teachers.
    /// </summary>
    /// <returns>ActionResult<List<SubjectDTO>> </returns>
    [HttpGet]
    public ActionResult<List<SubjectDTO>> GetAllTeachers()
    {
        return _subjectService.GetAllSubjects();
    }

    /// <summary>
    /// Gets the subject by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<SubjectDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<SubjectDTO> GetSubjectById(int id)
    {
        return _subjectService.GetSubjectById(id);
    }
}

