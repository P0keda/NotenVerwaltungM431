using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherController"/> class.
    /// </summary>
    /// <param name="teacherService">The teacher service.</param>
    public TeacherController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    /// <summary>
    /// Gets all teachers.
    /// </summary>
    /// <returns>ActionResult<List<TeacherDTO>></returns>
    [HttpGet]
    public ActionResult<List<TeacherDTO>> GetAllTeachers()
    {
        return _teacherService.GetAllTeachers();
    }

    /// <summary>
    /// Gets the teacher by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<TeacherDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<TeacherDTO> GetTeacherById(int id)
    {
        return _teacherService.GetTeacherById(id);
    }
}
