using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GradeController : ControllerBase
{
    private readonly IGradeService _gradeService;

    public GradeController(IGradeService gradeService)
    {
        _gradeService = gradeService;
    }

    [HttpGet]
    public ActionResult<List<GradeDTO>> GetAllGrades()
    {
        return _gradeService.GetAllGrades();
    }
    [HttpGet("{id}")]
    public ActionResult<GradeDTO> GetGradeById(int id)
    {
        return _gradeService.GetGradeById(id);
    }

    [HttpGet("{studentId}")]
    public ActionResult<List<GradeDTO>> GetGradeByStudentId(int studentId)
    {
        return _gradeService.GetGradeByStudentId(studentId);
    }

    [HttpGet("{studentId}")]
    public ActionResult<List<GradeDTO>> GetGradeByStudentIdAndSubjectID(int studentId, int subjectId)
    {
        return _gradeService.GetGradeByStudentIdAndSubjectId(studentId, subjectId);
    }
}
