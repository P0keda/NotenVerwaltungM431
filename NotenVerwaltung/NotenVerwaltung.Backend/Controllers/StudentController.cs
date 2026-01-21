using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    /// <summary>
    /// Initializes a new instance of the <see cref="StudentController"/> class.
    /// </summary>
    /// <param name="studentService">The student service.</param>
    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    /// <summary>
    /// Gets all student.
    /// </summary>
    /// <returns>ActionResult<List<StudentDTO>></returns>
    [HttpGet]
    public ActionResult<List<StudentDTO>> GetAllStudent()
    {
        return _studentService.GetAllStudents();
    }

    /// <summary>
    /// Gets all students.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<StudentDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<StudentDTO> GetAllStudents(int id)
    {
        return _studentService.GetStudentById(id);
    }
}
