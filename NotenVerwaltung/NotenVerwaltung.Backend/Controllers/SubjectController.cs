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

    public SubjectController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet]
    public ActionResult<List<SubjectDTO>> GetAllTeachers()
    {
        return _subjectService.GetAllSubjects();
    }
}

