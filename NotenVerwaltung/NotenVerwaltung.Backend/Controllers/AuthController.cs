using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthController"/> class.
    /// </summary>
    /// <param name="authService">The authentication service.</param>
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    /// <summary>
    /// Registers the specified register user dto.
    /// </summary>
    /// <param name="registerUserDTO">The register user dto.</param>
    /// <returns>ActionResult<object></returns>
    [HttpPost("register")]
    public ActionResult<object> Register([FromBody] RegisterUserDTO registerUserDTO)
    {
        var user = _authService.Register(registerUserDTO);
        return Ok(user);
    }

    /// <summary>
    /// Logins the specified login user dto.
    /// </summary>
    /// <param name="loginUserDTO">The login user dto.</param>
    /// <returns>ActionResult<object></returns>
    [HttpPost("login")]
    public ActionResult<object> Login([FromBody] LoginUserDTO loginUserDTO)
    {
        var user = _authService.Login(loginUserDTO);
        return Ok(user);
    }
}
