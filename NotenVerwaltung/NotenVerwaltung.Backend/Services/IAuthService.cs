using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IAuthService
{
    /// <summary>
    /// Registers the specified register user dto.
    /// </summary>
    /// <param name="registerUserDTO">The register user dto.</param>
    /// <returns>object</returns>
    object Register(RegisterUserDTO registerUserDTO);

    /// <summary>
    /// Logins the specified login user dto.
    /// </summary>
    /// <param name="loginUserDTO">The login user dto.</param>
    /// <returns>object</returns>
    object Login(LoginUserDTO loginUserDTO);
}
