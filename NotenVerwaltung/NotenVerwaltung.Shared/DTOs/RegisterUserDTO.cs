using System.ComponentModel.DataAnnotations;

namespace NotenVerwaltung.Shared.DTOs;

public class RegisterUserDTO
{
    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    [Required]
    [EmailAddress]
    [RegularExpression(@"^[a-z]+\.[a-z]+@(gibz|zg)\.ch$", ErrorMessage = "Email must have this format example.example@gibz.ch or example.example@zg.ch")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>
    /// The password.
    /// </value>
    [Required]
    [MinLength(6, ErrorMessage = "Password must be at least 6 character lenght")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the confirm password and compare it with password.
    /// </summary>
    /// <value>
    /// The confirm password.
    /// </value>
    [Required]
    [Compare("Password", ErrorMessage = "Password are not the same")]
    public string ConfirmPassword { get; set; }

    /// <summary>
    /// Gets or sets the full name.
    /// </summary>
    /// <value>
    /// The full name.
    /// </value>
    [Required(ErrorMessage = "Your full name is required")]
    public string FullName { get; set; }
}
