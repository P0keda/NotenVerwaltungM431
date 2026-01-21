using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GradeController : ControllerBase
{
    private readonly IGradeService _gradeService;

    /// <summary>
    /// Initializes a new instance of the <see cref="GradeController"/> class.
    /// </summary>
    /// <param name="gradeService">The grade service.</param>
    public GradeController(IGradeService gradeService)
    {
        _gradeService = gradeService;
    }

    /// <summary>
    /// Gets all grades.
    /// </summary>
    /// <returns>ActionResult<List<GradeDTO>></returns>
    [HttpGet]
    public ActionResult<List<GradeDTO>> GetAllGrades()
    {
        return _gradeService.GetAllGrades();
    }

    /// <summary>
    /// Gets the grade by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<GradeDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<GradeDTO> GetGradeById(int id)
    {
        return _gradeService.GetGradeById(id);
    }

    /// <summary>
    /// Gets the grade by student identifier.
    /// </summary>
    /// <param name="studentId">The student identifier.</param>
    /// <returns>ActionResult<List<GradeDTO>></returns>
    [HttpGet("student/{studentId}")]
    public ActionResult<List<GradeDTO>> GetGradeByStudentId(int studentId)
    {
        return _gradeService.GetGradeByStudentId(studentId);
    }

    /// <summary>
    /// Updates the grade.
    /// </summary>
    /// <param name="updateGradeDTO">The update grade dto.</param>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult</returns>
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
