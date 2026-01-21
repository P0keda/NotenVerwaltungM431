using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Frontend.Services;

public interface IAuthService
{
    /// <summary>
    /// Gets a value indicating whether this instance is authenticated.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is authenticated; otherwise, <c>false</c>.
    /// </value>
    bool IsAuthenticated { get; }

    /// <summary>
    /// Gets the name of the user.
    /// </summary>
    /// <value>
    /// The name of the user.
    /// </value>
    string? UserName { get; }

    /// <summary>
    /// Gets the role.
    /// </summary>
    /// <value>
    /// The role.
    /// </value>
    string? Role { get; }

    /// <summary>
    /// Gets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    public string Email { get; }

    /// <summary>
    /// Logins the asynchronous.
    /// </summary>
    /// <param name="dto">The dto.</param>
    /// <returns>true if login is success</returns>
    public Task<bool> LoginAsync(LoginUserDTO dto);

    /// <summary>
    /// Registers the asynchronous.
    /// </summary>
    /// <param name="dto">The dto.</param>
    /// <returns>true if register is success</returns>
    public Task<bool> RegisterAsync(RegisterUserDTO dto);

    /// <summary>
    /// Logouts the asynchronous.
    /// </summary>
    /// <returns>Task</returns>
    public Task LogoutAsync();

    /// <summary>
    /// Occurs when [on change].
    /// </summary>
    event Action? OnChange;
}
