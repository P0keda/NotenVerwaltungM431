using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public ActionResult<object> Register([FromBody] RegisterUserDTO registerUserDTO)
    {
        var user = _authService.Register(registerUserDTO);
        return Ok(user);
    }

    [HttpPost("login")]
    public ActionResult<object> Login([FromBody] LoginUserDTO loginUserDTO)
    {
        var user = _authService.Login(loginUserDTO);
        return Ok(user);
    }
}
