using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IAuthService
{
    object Register(RegisterUserDTO registerUserDTO);
    object Login(LoginUserDTO loginUserDTO);
}
