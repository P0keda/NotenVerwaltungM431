using NotenVerwaltung.Shared.DTOs;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _http;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthService"/> class.
    /// </summary>
    /// <param name="http">The HTTP.</param>
    public AuthService(HttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc />
    public bool IsAuthenticated { get; private set; } = false;

    /// <inheritdoc />
    public string UserName { get; private set; }

    /// <inheritdoc />
    public string Email { get; private set; }

    /// <inheritdoc />
    public string Role { get; private set; }

    /// <inheritdoc />
    public event Action? OnChange;

    /// <inheritdoc />
    public async Task<bool> LoginAsync(LoginUserDTO dto)
    {
        var response = await _http.PostAsJsonAsync("Auth/login", dto);

        if (!response.IsSuccessStatusCode)
        {
            return false;
        }
        IsAuthenticated = true;
        if (dto.Email.EndsWith("@gibz.ch"))
        {
            Role = "Teacher";
        }
        else if (dto.Email.EndsWith("@zg.ch"))
        {
            Role = "Prorector";
        }
        UserName = dto.Email.Split('@')[0].Replace(".", " ");
        Email = dto.Email;
        NotifyStateChanged();
        return true;
    }

    /// <inheritdoc />
    public async Task<bool> RegisterAsync(RegisterUserDTO dto)
    {
        var response = await _http.PostAsJsonAsync("Auth/register", dto);

        if (!response.IsSuccessStatusCode)
        {
            return false;
        }
        IsAuthenticated = true;
        if (dto.Email.EndsWith("@gibz.ch"))
        {
            Role = "Teacher";
        }
        else if (dto.Email.EndsWith("@zg.ch"))
        {
            Role = "Prorector";
        }
        UserName = dto.FullName;
        Email = dto.Email;
        NotifyStateChanged();
        return true;
    }

    /// <inheritdoc />
    public async Task LogoutAsync()
    {
        IsAuthenticated = false;
        UserName = null;
        Email = null;
        Role = null;
        NotifyStateChanged();
    }

    /// <inheritdoc />
    private void NotifyStateChanged() => OnChange?.Invoke();
}