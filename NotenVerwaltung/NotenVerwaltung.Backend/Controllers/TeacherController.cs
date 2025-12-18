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

    public TeacherController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpGet]
    public ActionResult<List<TeacherDTO>> GetAllTeachers()
    {
        return _teacherService.GetAllTeachers();
    }
}
