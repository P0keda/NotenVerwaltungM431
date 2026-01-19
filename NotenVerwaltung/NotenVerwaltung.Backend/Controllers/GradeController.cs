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

    [HttpGet("student/{studentId}")]
    public ActionResult<List<GradeDTO>> GetGradeByStudentId(int studentId)
    {
        return _gradeService.GetGradeByStudentId(studentId);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateGrade(UpdateGradeDTO updateGradeDTO, int id)
    {
        GradeDTO gradeDTO = _gradeService.UpdateGrade(updateGradeDTO, id);
        if (gradeDTO == null)
        {
            return BadRequest();
        }
        gradeDTO.GradeValue = updateGradeDTO.GradeValue;
        gradeDTO.Comment = updateGradeDTO.Comment;

        return Ok(gradeDTO);
    }
}
