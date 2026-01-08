using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public ActionResult<List<StudentDTO>> GetAllStudent()
    {
        return _studentService.GetAllStudents();
    }

    [HttpGet("{id}")]
    public ActionResult<StudentDTO> GetAllStudents(int id)
    {
        return _studentService.GetStudentById(id);
    }
}
